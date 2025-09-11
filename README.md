# 2025 Basta Spring Demos

Demos for my session "Post-Quantum Cryptography for .NET Developers" at Basta Spring 2025 in Mainz. 

## Notes on PQC algorithms demo

### BouncyCastle

The demo should worked on all platforms because it is fully managed code.

### LibOQS.NET

The demo should work on:

- Windows x64 and arm64
- Linux x64 and arm64
- macOS arm64

### System.Security.Cryptography

The demo should work on:

- Windows x64 and arm64 - but only if you are on Windows Insiders, Canary Channel Build 27852 and higher
- Linux x64 and arm64 - but only if you are on a distro that supports OpenSSL 3.5 or higher

If your Linux has lower version of OpenSSL, you can try the following:

```bash
export OPENSSL_ROOT=/path/to/your/openssl-3.5
export LD_LIBRARY_PATH="$OPENSSL_ROOT/lib:${LD_LIBRARY_PATH}"
export OPENSSL_MODULES="$OPENSSL_ROOT/lib/ossl-modules"
export PATH="$OPENSSL_ROOT/bin:$PATH"
```