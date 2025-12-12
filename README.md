[comment]: <> (HEAD)
# TextMagic C# / .NET SDK

[![NuGet version](https://badge.fury.io/nu/TextMagicClient.svg)](https://badge.fury.io/nu/TextMagicClient)
[![.NET Standard](https://img.shields.io/badge/.NET%20Standard-2.0-blue.svg)](https://docs.microsoft.com/en-us/dotnet/standard/net-standard)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

This library provides you with an easy way to send SMS and receive replies by integrating the TextMagic SMS Gateway into your C# / .NET application.

## What Is TextMagic?
TextMagic's application programming interface (API) provides the communication link between your application and TextMagic's SMS Gateway, allowing you to send and receive text messages and to check the delivery status of text messages you've already sent.


[comment]: <> (/HEAD)

## Requirements

- **.NET Standard 2.0** or higher
- **Compatible with:**
  - .NET Framework 4.6.1+
  - .NET Core 2.0+
  - .NET 5.0+
  - .NET 6.0+
  - .NET 7.0+
  - .NET 8.0+
  - Mono 5.4+
  - Xamarin.iOS 10.14+
  - Xamarin.Android 8.0+
  - UWP 10.0.16299+

## Dependencies

- **[RestSharp](https://www.nuget.org/packages/RestSharp)** >= 112.0.0
- **[Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)** >= 13.0.3
- **[JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/)** >= 2.0.1

All dependencies are automatically installed via NuGet when you install the package.

## Installation

### Install from NuGet (Recommended)

#### Using Package Manager Console
```powershell
Install-Package TextMagicClient
```

#### Using .NET CLI
```bash
dotnet add package TextMagicClient
```

#### Using PackageReference
Add this to your `.csproj` file:
```xml
<PackageReference Include="TextMagicClient" Version="3.0.43912" />
```

### Install from GitHub

```bash
git clone https://github.com/textmagic/textmagic-rest-csharp-v2.git
cd textmagic-rest-csharp-v2/src/TextMagicClient
dotnet build
```

## Quick Start

### Basic Usage

```csharp
using System;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure API credentials
            // Get your credentials from https://app.textmagic.com/settings/api
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_API_KEY";
            Configuration.Default.BasePath = "https://rest.textmagic.com";

            var api = new TextMagicApi();

            // Test connection
            try
            {
                var result = api.Ping();
                Console.WriteLine($"✅ Connected! Server time: {result.Ping}");
            }
            catch (ApiException e)
            {
                Console.WriteLine($"❌ Error: {e.Message}");
            }
        }
    }
}
```

## Usage Examples

### Sending Messages

```csharp
using System;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_API_KEY";
            Configuration.Default.BasePath = "https://rest.textmagic.com";

            var api = new TextMagicApi();

            // Send SMS to a single number
            try
            {
                var sendMessage = new SendMessageInputObject
                {
                    Text = "Hello from TextMagic C# SDK!",
                    Phones = "+1234567890"
                };

                var result = api.SendMessage(sendMessage);
                Console.WriteLine($"✅ Message sent! ID: {result.Id}");
                Console.WriteLine($"   Session ID: {result.SessionId}");
            }
            catch (ApiException e)
            {
                Console.WriteLine($"❌ Error sending message: {e.Message}");
            }

            // Send SMS to multiple numbers
            try
            {
                var sendMessage = new SendMessageInputObject
                {
                    Text = "Bulk message from TextMagic!",
                    Phones = "+1234567890,+0987654321"
                };

                var result = api.SendMessage(sendMessage);
                Console.WriteLine($"✅ Bulk message sent! Session ID: {result.SessionId}");
            }
            catch (ApiException e)
            {
                Console.WriteLine($"❌ Error: {e.Message}");
            }
        }
    }
}
```

### Retrieving Messages

```csharp
using System;
using TextMagicClient.Api;
using TextMagicClient.Client;

namespace ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_API_KEY";
            Configuration.Default.BasePath = "https://rest.textmagic.com";

            var api = new TextMagicApi();

            // Get all outbound messages with pagination
            try
            {
                int page = 1;
                int limit = 10;
                var result = api.GetAllOutboundMessages(page, limit);

                Console.WriteLine($"📨 Total messages: {result.Page.Count}");
                foreach (var message in result.Resources)
                {
                    Console.WriteLine($"   ID: {message.Id}, Text: {message.Text}, Status: {message.Status}");
                }
            }
            catch (ApiException e)
            {
                Console.WriteLine($"❌ Error: {e.Message}");
            }

            // Get a specific message by ID
            try
            {
                int messageId = 12345;
                var message = api.GetMessage(messageId);
                Console.WriteLine($"📨 Message {message.Id}: {message.Text}");
                Console.WriteLine($"   Status: {message.Status}");
                Console.WriteLine($"   Sent at: {message.CreateTime}");
            }
            catch (ApiException e)
            {
                Console.WriteLine($"❌ Error: {e.Message}");
            }
        }
    }
}
```

### Uploading Files

```csharp
using System;
using System.IO;
using TextMagicClient.Api;
using TextMagicClient.Client;

namespace ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_API_KEY";
            Configuration.Default.BasePath = "https://rest.textmagic.com";

            var api = new TextMagicApi();

            // Upload list avatar
            try
            {
                int listId = 12345;
                using (var stream = File.OpenRead("path/to/avatar.png"))
                {
                    var result = api.UploadListAvatar(stream, listId);
                    Console.WriteLine($"✅ Avatar uploaded! URL: {result.Href}");
                }
            }
            catch (ApiException e)
            {
                Console.WriteLine($"❌ Error: {e.Message}");
            }
        }
    }
}
```

### Error Handling

```csharp
using System;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_API_KEY";
            Configuration.Default.BasePath = "https://rest.textmagic.com";

            var api = new TextMagicApi();

            try
            {
                var sendMessage = new SendMessageInputObject
                {
                    Text = "Test message",
                    Phones = "+1234567890"
                };

                var result = api.SendMessage(sendMessage);
                Console.WriteLine($"✅ Success! Message ID: {result.Id}");
            }
            catch (ApiException e)
            {
                Console.WriteLine($"❌ API Error:");
                Console.WriteLine($"   Status Code: {e.ErrorCode}");
                Console.WriteLine($"   Message: {e.Message}");
                Console.WriteLine($"   Response: {e.ErrorContent}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"❌ Unexpected Error: {e.Message}");
            }
        }
    }
}
```

## API Documentation

For detailed information about all available methods, parameters, and response models, please refer to:

- **[TextMagic API Documentation](https://docs.textmagic.com)**
- **[REST API Reference](https://docs.textmagic.com/api-reference)**

### Available API Methods

The SDK provides access to all TextMagic REST API endpoints, including:

- **Messages**: Send, retrieve, delete messages
- **Contacts**: Manage contacts and contact lists
- **Templates**: Create and manage message templates
- **Bulk Operations**: Send bulk messages, manage campaigns
- **Account**: Check balance, get account information
- **Numbers**: Purchase and manage dedicated numbers
- **Webhooks**: Configure webhooks for incoming messages
- **And more...**

## VB.NET Usage Example

```vbnet
Imports System
Imports System.IO
Imports TextMagicClient.Api
Imports TextMagicClient.Client
Imports TextMagicClient.Model

Module Program
    Sub Main(args As String())
        ' put your Username and API Key from https://my.textmagic.com/online/api/rest-api/keys page.
        Configuration.Default.Username = "YOUR_USERNAME"
        Configuration.Default.Password = "YOUR_API_KEY"
        Configuration.Default.BasePath = "https://rest.textmagic.com"

        Dim apiInstance = New TextMagicApi()

        ' Simple Ping request sample
        Try
            Dim result = apiInstance.Ping()
            Console.WriteLine(result.Ping)
            Catch ex As Exception
            Console.WriteLine("Exception when calling TextMagicApi.Ping: " + ex.Message )
        End Try

        ' Send a new message request sample
        Try
            Dim sendMessageInputObject = New SendMessageInputObject With {
            .Text = "I love TextMagic!",
            .Phones = "+199988887766"
            }
            Dim result = apiInstance.SendMessage(sendMessageInputObject)
            Console.WriteLine(result.Id)
        Catch e As Exception
            Console.WriteLine("Exception when calling TextMagicApi.SendMessage: " & e.Message)
        End Try

        ' Get all outgoing messages sample
        Try
            Dim result = apiInstance.GetAllOutboundMessages(1, 10)
            Console.WriteLine(result.Resources(0).Id)
        Catch e As Exception
            Console.WriteLine("Exception when calling TextMagicApi.GetAllOutboundMessages: " & e.Message)
        End Try

        ' Upload list avatar sample, 3223 here is a sample list id
        Try
            Dim stream = File.Open("/CustomPath/Images/test.png", FileMode.Open)
            Dim result = apiInstance.UploadListAvatar(stream, 3223)
            Console.WriteLine(result.Href)
        Catch e As Exception
            Console.WriteLine("Exception when calling TextMagicApi.UploadListAvatar: " & e.Message)
        End Try
    End Sub
End Module

```

## Migration Guide: v2.x → v3.x

### Overview

Version 3.0 represents a major update to the TextMagic C# SDK, migrating from Swagger Codegen to OpenAPI Generator 7.17.0. This brings improved code quality, better .NET Standard support, and enhanced compatibility with modern .NET frameworks.

### Why Upgrade?

- ✅ **Modern .NET Support**: Full .NET Standard 2.0 support, compatible with .NET 6.0, 7.0, 8.0+
- ✅ **Updated Dependencies**: Latest versions of RestSharp, Newtonsoft.Json, and JsonSubTypes
- ✅ **Better Code Generation**: OpenAPI Generator 7.17.0 produces cleaner, more maintainable code
- ✅ **Improved Performance**: Optimized HTTP client and serialization
- ✅ **Enhanced Security**: Updated dependencies with latest security patches
- ✅ **Future-Proof**: Active maintenance and regular updates

### Breaking Changes

| Change | Impact | v2.x | v3.x | Notes |
|--------|--------|------|------|-------|
| **Generator** | Low | Swagger Codegen 2.4.8 | OpenAPI Generator 7.17.0 | Modern code generation |
| **Target Framework** | Medium | .NET Framework 4.5 | .NET Standard 2.0+ | Requires .NET Framework 4.6.1+ |
| **RestSharp** | Medium | 105.1.0 | **112.0.0+** | **+7 major versions!** Improved performance |
| **Newtonsoft.Json** | Low | 10.0.3 | 13.0.3+ | Latest security patches |
| **JsonSubTypes** | Low | 1.2.0 | 2.0.1+ | Major version update |
| **Package Installation** | Low | Manual DLL or NuGet | NuGet (recommended) | Simplified installation |

### What Stays the Same ✅

- ✅ **API Interface**: All method signatures remain unchanged
- ✅ **Authentication**: Same username/password authentication
- ✅ **Configuration**: Same `Configuration.Default` pattern
- ✅ **Model Classes**: Same model structure and properties
- ✅ **Error Handling**: Same `ApiException` handling
- ✅ **Base URL**: Same `https://rest.textmagic.com` endpoint

### Step-by-Step Migration Guide

#### Step 1: Backup Your Project
```bash
# Create a backup of your project
git commit -am "Backup before TextMagic SDK v3 migration"
# or copy your project folder
```

#### Step 2: Check .NET Framework Version
Ensure your project targets **.NET Framework 4.6.1+**, **.NET Core 2.0+**, or **.NET 5.0+**.

```xml
<!-- Check your .csproj file -->
<TargetFramework>netstandard2.0</TargetFramework>
<!-- or -->
<TargetFramework>net6.0</TargetFramework>
```

#### Step 3: Remove Old SDK
```powershell
# Using Package Manager Console
Uninstall-Package TextMagicClient

# Or using .NET CLI
dotnet remove package TextMagicClient
```

#### Step 4: Install New SDK
```powershell
# Using Package Manager Console
Install-Package TextMagicClient -Version 3.0.43912

# Or using .NET CLI
dotnet add package TextMagicClient --version 3.0.43912
```

#### Step 5: Update Dependencies (if needed)
The new SDK will automatically install compatible versions of:
- RestSharp >= 112.0.0
- Newtonsoft.Json >= 13.0.3
- JsonSubTypes >= 2.0.1

#### Step 6: Rebuild Your Project
```bash
dotnet build
```

#### Step 7: Test Your Application
Run your test suite to ensure everything works as expected.

```bash
dotnet test
```

### Code Migration Examples

#### Example 1: Basic Configuration (No Changes Required)

**v2.x:**
```csharp
using TextMagicClient.Api;
using TextMagicClient.Client;

Configuration.Default.Username = "YOUR_USERNAME";
Configuration.Default.Password = "YOUR_API_KEY";
Configuration.Default.BasePath = "https://rest.textmagic.com";

var api = new TextMagicApi();
```

**v3.x:**
```csharp
using TextMagicClient.Api;
using TextMagicClient.Client;

Configuration.Default.Username = "YOUR_USERNAME";
Configuration.Default.Password = "YOUR_API_KEY";
Configuration.Default.BasePath = "https://rest.textmagic.com";

var api = new TextMagicApi();
```
✅ **No changes required!**

#### Example 2: Sending Messages (No Changes Required)

**v2.x:**
```csharp
using TextMagicClient.Model;

var sendMessage = new SendMessageInputObject
{
    Text = "Hello from TextMagic!",
    Phones = "+1234567890"
};

var result = api.SendMessage(sendMessage);
Console.WriteLine($"Message ID: {result.Id}");
```

**v3.x:**
```csharp
using TextMagicClient.Model;

var sendMessage = new SendMessageInputObject
{
    Text = "Hello from TextMagic!",
    Phones = "+1234567890"
};

var result = api.SendMessage(sendMessage);
Console.WriteLine($"Message ID: {result.Id}");
```
✅ **No changes required!**

#### Example 3: Error Handling (No Changes Required)

**v2.x:**
```csharp
try
{
    var result = api.Ping();
    Console.WriteLine(result.Ping);
}
catch (ApiException e)
{
    Console.WriteLine($"Error: {e.Message}");
}
```

**v3.x:**
```csharp
try
{
    var result = api.Ping();
    Console.WriteLine(result.Ping);
}
catch (ApiException e)
{
    Console.WriteLine($"Error: {e.Message}");
}
```
✅ **No changes required!**

### Common Migration Issues & Solutions

#### Issue 1: "Could not load file or assembly 'RestSharp'"

**Cause**: Version mismatch between old and new RestSharp.

**Solution**:
```powershell
# Clean and rebuild
dotnet clean
dotnet restore
dotnet build
```

#### Issue 2: "The type or namespace name 'TextMagicClient' could not be found"

**Cause**: Old package not properly uninstalled.

**Solution**:
```powershell
# Remove all TextMagic packages
Uninstall-Package TextMagicClient -Force

# Clear NuGet cache
dotnet nuget locals all --clear

# Reinstall
Install-Package TextMagicClient
```

#### Issue 3: ".NET Framework version not supported"

**Cause**: Project targets .NET Framework < 4.6.1.

**Solution**:
Update your `.csproj` file:
```xml
<TargetFramework>net461</TargetFramework>
<!-- or -->
<TargetFramework>netstandard2.0</TargetFramework>
```

#### Issue 4: "Newtonsoft.Json version conflict"

**Cause**: Another package requires a different Newtonsoft.Json version.

**Solution**:
Add binding redirect to `app.config` or `web.config`:
```xml
<runtime>
  <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
    <dependentAssembly>
      <assemblyIdentity name="Newtonsoft.Json" publicKeyToken="30ad4fe6b2a6aeed" culture="neutral" />
      <bindingRedirect oldVersion="0.0.0.0-13.0.0.0" newVersion="13.0.0.0" />
    </dependentAssembly>
  </assemblyBinding>
</runtime>
```

#### Issue 5: "RestSharp version conflict with other packages"

**Cause**: Another package in your project requires an older RestSharp version (< 112.0.0).

**Solution**:
```xml
<!-- Option 1: Add binding redirect to app.config or web.config -->
<runtime>
  <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
    <dependentAssembly>
      <assemblyIdentity name="RestSharp" publicKeyToken="598062e77f915f75" culture="neutral" />
      <bindingRedirect oldVersion="0.0.0.0-112.0.0.0" newVersion="112.0.0.0" />
    </dependentAssembly>
  </assemblyBinding>
</runtime>
```

```xml
<!-- Option 2: Update other packages to support RestSharp 112+ -->
<!-- Check if newer versions of conflicting packages are available -->
```

**Note**: RestSharp 112.0.0 includes significant improvements and breaking changes from 105.x. If you have custom RestSharp code, review the [RestSharp migration guide](https://restsharp.dev/v107/#migrating-from-restsharp-106x).

#### Issue 6: "SSL/TLS connection errors"

**Cause**: Older .NET Framework versions may not support modern TLS.

**Solution**:
```csharp
// Add this before making API calls
System.Net.ServicePointManager.SecurityProtocol = 
    System.Net.SecurityProtocolType.Tls12 | 
    System.Net.SecurityProtocolType.Tls13;
```

### Benefits of Upgrading to v3.x

#### Technical Improvements
- **Modern .NET Support**: Compatible with .NET 6.0, 7.0, 8.0, and future versions
- **Better Performance**: 
  - RestSharp 112.0.0 brings significant performance improvements
  - Optimized HTTP client with better connection pooling
  - Faster JSON serialization and deserialization
- **Improved Code Quality**: Cleaner generated code with better documentation
- **Enhanced Type Safety**: Stronger typing and better IntelliSense support
- **Updated Dependencies**: 
  - RestSharp 105.1.0 → **112.0.0** (+7 major versions with bug fixes and improvements)
  - Newtonsoft.Json 10.0.3 → 13.0.3 (latest security patches)
  - JsonSubTypes 1.2.0 → 2.0.1 (major version update)
- **Cross-Platform**: Works on Windows, Linux, and macOS

#### Ecosystem Alignment
- **Consistent with Other SDKs**: All TextMagic SDKs now use OpenAPI Generator
- **Better Tooling**: Improved IDE support and debugging experience
- **Active Maintenance**: Regular updates and community support
- **Future-Proof**: Built on actively maintained tools and frameworks

#### Security & Maintenance
- **Security Updates**: Latest dependency versions with security patches
- **Bug Fixes**: Resolved issues from Swagger Codegen
- **Long-Term Support**: OpenAPI Generator is actively maintained
- **Compliance**: Better support for modern security standards

### Migration Effort vs. Benefits

| Aspect | Effort | Benefit |
|--------|--------|---------|
| **Code Changes** | ⭐ Minimal (mostly none) | ⭐⭐⭐⭐⭐ No breaking API changes |
| **Dependency Updates** | ⭐⭐ Low (automatic) | ⭐⭐⭐⭐⭐ Latest security patches |
| **Testing** | ⭐⭐⭐ Medium | ⭐⭐⭐⭐⭐ Ensures compatibility |
| **Overall Migration** | ⭐⭐ Low | ⭐⭐⭐⭐⭐ Future-proof, secure, performant |

### Need Help?

- **Documentation**: [https://docs.textmagic.com](https://docs.textmagic.com)
- **Support**: [https://www.textmagic.com/support](https://www.textmagic.com/support)
- **GitHub Issues**: [https://github.com/textmagic/textmagic-rest-csharp-v2/issues](https://github.com/textmagic/textmagic-rest-csharp-v2/issues)

[comment]: <> (FOOTER)
## License
The library is available as open source under the terms of the [MIT License](http://opensource.org/licenses/MIT).

[comment]: <> (/FOOTER)
