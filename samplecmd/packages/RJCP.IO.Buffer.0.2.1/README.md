# RJCP.IO.Buffer <!-- omit in toc -->

This library contains a set of useful implementations that can be used in
multiple different projects.

- [1. Features](#1-features)
  - [1.1. .NET 4.x AsyncResult](#11-net-4x-asyncresult)
  - [1.2. Timer Expiry](#12-timer-expiry)
  - [1.3. Circular Buffer](#13-circular-buffer)
  - [1.4. Memory Read Buffer, Memory Write Buffer](#14-memory-read-buffer-memory-write-buffer)
- [2. Release History](#2-release-history)
  - [2.1. Version 0.2.1](#21-version-021)
  - [2.2. Version 0.2.0](#22-version-020)

## 1. Features

### 1.1. .NET 4.x AsyncResult

Provides a base class to create your own `IAsyncResult` methods. It originally
debutted at Microsoft's [DevBlog - How to Implement IAsyncResult in Another
Way](https://devblogs.microsoft.com/nikos/how-to-implement-iasyncresult-in-another-way.aspx),
which is no defunct, and no copy by the Wayback Machine was found.

It is recommended to use `IAsyncResult` only for backwards compatibility, the
`Task` paradigm is much more robust.

Implement your own `BeginXXX` and `EndXXX` as:

```csharp
public IAsyncResult BeginXXX(object par1, object par2, AsyncCallback asyncCallback, object state)
{
    XXXAsyncResult result = new XXXAsyncResult(par1, par2, asyncCallback, state, this, "XXX");
    result.Process();
    return result;


public void EndXXX(IAsyncResult result)
{
    AsyncResult.End(result, this, "XXX");
}
```

Your own `IAsyncResult` could look like:

```csharp
internal class XXXAsyncResult : AsyncResult
{
    private object m_Par1;
    private object m_Par2;

    public XXXAsyncResult(object par1, object par2, AsyncCallback asyncCallback, object state,
                         object owner, string operationId)
        : base(asyncCallback, state, owner, operationId)
    {
        m_Par1 = par1;
        m_Par2 = par2;
    }

    public override void Process()
    {
        Exception exception = null;
        bool synchronous = false;
        try {
            // Do something with m_Par1 and m_Par2. This may be
            // creating a new thread
            ...

            // Indicates that the work is finished without running
            // in the background.
            synchronous = true;
        } catch (System.Exception e) {
            exception = e;
        }
        Complete(exception, synchronous);
    }
}
```

### 1.2. Timer Expiry

There are many scenarios where it is useful to maintain timeout scenarios, where
the remaining time out from a loop must be maintained for the user. For example,
imaging a stream implementing a packet protocol (the `Read` would return a
complete packet), and the underlying transport is byte based. The user might
want to wait for a packet with a timeout.

The `TimerExpiry` makes this easier, by calculating any new timeouts remaining
that might be given as a timeout to underlying I/O operations.

It would be instantiated with the _user_ timeout, in milliseconds. And then in a
loop, one would check for a `CancellationToken`, and get the timeout still
remaining before calling underlying API.

The exit to the loop is if the `TimerExpiry.Expired` property is `true`.

### 1.3. Circular Buffer

Applications may want to have a bounded buffer when reading from underlying
(byte-based) I/O. This is useful for buffered I/O, where data is read (or
polled), and copied into a buffer, so that other applications can read out that
buffer at their own time.

A practical use case for a Circular Buffer is in the SerialPortStream, where
buffers are handed directly to the driver, where not all drivers can handle
arbitrary sized buffers.

The implementation uses locking to maintain the state.

The character extension handles the case of character circular buffers, and
converting byte buffers to character buffers, especially some very corner cases
that there are exceptions because not enough contiguous space might be available
when doing the conversion. The implementation will split it up into 16-bit
UTF-16 words and split them, abstracting the special case making the buffer look
linear.

### 1.4. Memory Read Buffer, Memory Write Buffer

The `MemoryReadBuffer` and `MemoryWriteBuffer` is for I/O operations, that wrap
around the `CircularBuffer`, handling a producer and consumer of the data (one
end being the client, the other end being the underlying I/O device). This is
used by the SerialPortStream.

## 2. Release History

### 2.1. Version 0.2.1

- Updated from .NET 4.5 to 4.6.2 (DOTNET-827) and .NET Standard 2.1 to .NET 6.0
  (DOTNET-936, DOTNET-942, DOTNET-945).

### 2.2. Version 0.2.0

- First version, refactored from SerialPortStream
