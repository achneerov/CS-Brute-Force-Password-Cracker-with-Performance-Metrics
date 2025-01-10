# Brute Force Password Cracker

This is a simple brute-force password cracker written in C#. It generates and tests all possible combinations of a given charset and attempts to find the correct password. The program supports customization of the charset and the maximum password length to test.

## Features

- **Charset Customization:** You can modify the set of characters used in the brute-force attempt (default: lowercase, uppercase letters, and digits).
- **Max Password Length:** Allows you to specify the maximum length of the password to attempt.
- **Performance Metrics:** Outputs the number of combinations tested and the time taken to crack the password.

## Requirements

- **.NET SDK**: The application requires the .NET SDK to run (version 5.0 or higher).
- **C# Compiler**: A C# compiler is required to compile and run the program.

## Installation

1. Clone this repository or download the code to your local machine.

   ```bash
   git clone https://github.com/yourusername/brute-force-password-cracker.git
   cd brute-force-password-cracker
   ```

2. Open the project in your preferred IDE or editor.

3. Compile the project using the .NET SDK:

   ```bash
   dotnet build
   ```

4. Run the application:

   ```bash
   dotnet run
   ```

## Configuration

The program includes configurable parameters for the password cracking process:

- **Target Password**: The password you're trying to crack. By default, it's set to `"aB1"`.
- **Charset**: The set of characters to use in the brute-force attempt. The default charset is:
  
  ```csharp
  "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
  ```

  You can customize the charset by modifying the `charset` variable in the `Main` method.

- **Max Password Length**: The maximum password length to test. Default is `4`. You can change this value based on your needs.

## Example

### Default Settings

With the default settings, the program will attempt to crack the password `"aB1"`, using a charset containing lowercase, uppercase letters, and digits, with a maximum password length of 4.

### Customizing the Target Password

To change the target password, modify the `targetPassword` variable in the `Main` method:

```csharp
string targetPassword = "YourPasswordHere";  // Set your desired password to crack
```

### Customizing the Charset

To use a custom charset, modify the `charset` variable:

```csharp
char[] charset = "0123456789".ToCharArray();  // Use only digits
```

### Example Output

```
Password cracked! The password is: aB1
Total combinations tested: 756
Cracking time: 0.1 seconds.
```

## Limitations

- The brute force approach can be time-consuming, especially for longer passwords or larger charsets.
- As the password length and charset size increase, the number of combinations increases exponentially.

