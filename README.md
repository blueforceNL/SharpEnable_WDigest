# SharpEnable_WDigest

Running this executable will set the "UseLogonCredential" value to 1, making WDigest store the credentials in memory.

# Installation

- Download from Github
- Compile
- Run on your target machine

# What's it for?

In Windows 8.1 and Windows Server 2012 R2 and later versions, caching of credentials in memory for WDigest is disabled. When you dump credentials with Mimikatz and other tools, you’ll need to exfiltrate and crack the hashes to get to the passwords.

You can enable caching of plaintext passwords again with Powershell:

	PS C:\> reg add HKLM\SYSTEM\CurrentControlSet\Control\SecurityProviders\WDigest /v UseLogonCredential /t REG_DWORD /d 1

But this will leave traces in the command line log and EDR tools will detect it. 

This tool is an executable that uses the Windows API to enable UseLogonCredential and will not leave any traces in command line logs.
