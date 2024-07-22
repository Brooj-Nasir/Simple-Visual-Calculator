# Visual Calculator Documentation

## Overview

This visual calculator is a Windows Forms application designed in C Sharp to perform basic arithmetic operations and logarithmic calculations. It features a user-friendly graphical interface, allowing users to input numbers, perform calculations, and view results efficiently.
## GUI
Heres how the gui of it looks like:

![calculator](https://github.com/user-attachments/assets/e47fd52e-bc9c-4e85-a2b6-4e0866171dfd)


## Features

- **Basic Arithmetic Operations**: Addition, subtraction, multiplication, and division.
- **Logarithmic Calculation**: Computes the logarithm of a given number.
- **Clear Functionality**: Resets the current input.
- **Result Display**: Shows the result of calculations in a text box.

## How to Use

1. **Input Numbers**: Click the numeric buttons (`0` through `9`) to enter numbers into the text box.
2. **Perform Operations**: Click the arithmetic operation buttons (`+`, `-`, `*`, `/`) to set the desired operation.
3. **Compute Result**: Click the `=` button to calculate the result of the operation.
4. **Clear Input**: Click the `clr` button to clear the current input.
5. **Logarithm Calculation**: Click the `log` button to compute the logarithm of the input number.

## Code Files

- **[Form1.Designer.cs](here)**: This file contains the auto-generated code used for designing the form. It includes the initialization of components and the layout settings of the calculator interface. This is where the UI elements are created and configured.

- **[Form1.cs](here)**: This file contains the logic for the calculator's functionality. It includes event handlers for button clicks and the core logic for performing arithmetic operations and displaying results. The code handles user interactions and performs calculations based on the selected operations.

- **[Program.cs](here)**: This is the entry point of the application. It initializes the application and runs the main form. It contains the `Main` method, which sets up the application configuration and starts the Windows Forms application.

## Requirements

- .NET Framework
- Windows Operating System

## Installation

1. Clone or download the repository.
2. Open the project in Visual Studio.
3. Build and run the application.

## Contributions

Contributions are welcome! Please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Sample Code

Below is a sample usage of the calculator:

```csharp
// Click button1 to append "1" to the text box
btn1_Click(sender, e);

// Click btn_Plus to set the operation to addition
btn_Plus_Click(sender, e);

// Click btn_Equal to compute the result
btn_Equal_Click(sender, e);
