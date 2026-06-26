# Blazor EditForm Validation

Build a robust employee information form with real-time validation using Blazor's `EditForm` component and Blazor components ([TextBox](https://www.syncfusion.com/blazor-components/blazor-textbox), [DatePicker](https://www.syncfusion.com/blazor-components/blazor-datepicker), [NumericTextBox](https://www.syncfusion.com/blazor-components/blazor-numeric-textbox), [RadioButton](https://www.syncfusion.com/blazor-components/blazor-radio-button), [ComboBox](https://www.syncfusion.com/blazor-components/blazor-combobox), [DropDownList](https://www.syncfusion.com/blazor-components/blazor-dropdown-list)). This sample demonstrates best practices for form validation with Data Annotations and server-side validation in a modern Blazor application.

## Overview

This Blazor application provides a complete example of building and validating a form with multiple input types. The Employee Details Form demonstrates:

- **Data Annotations Validation**: Built-in .NET validation attributes (`Required`, `EmailAddress`, `Phone`, `Range`, etc.)
- **Real-time Validation**: Immediate feedback as users fill out the form
- **Blazor Components Integration**: TextBox, DatePicker, NumericTextBox, RadioButton, ComboBox, and DropDownList
- **Responsive Design**: Mobile-friendly Bootstrap grid layout
- **Dynamic Cascading Dropdowns**: City selection updates based on selected country
- **Comprehensive Error Handling**: Validation messages for each field

## Features

- **EditForm with Data Annotations** - Declarative validation using attributes  
- **Multiple Input Types** - Text, email, phone, dates, numbers, and dropdowns
- **Cascading Dropdowns** - City list filtered by selected country  
- **Radio Buttons** - Gender selection with Blazor components  
- **Validation Summary** - Display all validation errors at once  
- **Submit & Reset** - Handle form submissions and data reset  
- **Bootstrap Layout** - Responsive grid system for various screen sizes  

## Prerequisites

* [.NET SDK 10.0](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) or later
* [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later
* [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/SyncfusionExamples/blazor-edit-form-validation.git
cd blazor-edit-form-validation
```

### Run with Visual Studio

1. Open the solution file using Visual Studio 2022 or later.
2. Restore the NuGet packages by rebuilding the solution.
3. Build the project to ensure there are no compilation errors.
4. Run the project.

### Run with .NET CLI

```bash
# Restore dependencies
dotnet restore

# Run the project
dotnet run
```

## References

- [Online examples](https://blazor.syncfusion.com/demos/)
- [Documentation](https://blazor.syncfusion.com/documentation/getting-started/blazor-server-side-visual-studio)
- [Blog reference](https://www.syncfusion.com/blogs/post/spice-up-your-blazor-editform-with-syncfusion-blazor-components)