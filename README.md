# Firewall Project (GUI in C#)

## Introduction
This repository contains a firewall application developed in C#, designed to provide an intuitive graphical user interface (GUI) for managing firewall rules. The application allows users to define custom rules, validate packets, and enhance network security.

## Technology Stack
- **Programming Language**: C#
- **Framework**: .NET Framework (version 4.7 or higher)
- **IDE/Compiler**: Visual Studio 2019 (or higher)
- **Supported Platforms**: Windows OS

## Requirements
- **Development Environment**: Visual Studio 2019 or later (with Windows Forms development workload installed).
- **Framework**: .NET Framework 4.7 or later.

## Supported Compilers/IDEs
- Visual Studio 2019
- Visual Studio 2022

## Forms and Classes

### Forms
1. **Welcome Form**: Entry point of the application. Contains navigation buttons to access tutorials and the main firewall program.
2. **Tutorial Form**: Provides step-by-step instructions for using the firewall and adding custom rules.
3. **Firewall Form**: Central interface for validating packets and managing rules. Allows users to:
    - Enter source and destination IP addresses, ports, and protocols.
    - View default and custom rules.
    - Add custom rules.
4. **Admin Login Form**: Secures access to the custom rule management section.
5. **Add Custom Rules Form**: Enables users to define and add custom rules to the firewall.

### Classes
1. **Packet Class**: Represents a network packet with attributes such as source/destination IP, port, protocol, and timestamp.
2. **Rule Class**: Defines firewall rules with properties like rule number, IP address, port, protocol, and decision (allow or deny).
3. **Firewall Class**: Manages default and custom rules, and validates packets against these rules. Contains methods for loading rules, adding new ones, and performing packet checks.

## Workflow
1. **Welcome Page**:
   - Users start at the Welcome Form, where they can choose to view a tutorial or proceed to the Firewall Form.
2. **Tutorial Form**:
   - Provides a guide on how to use the application and manage rules.
3. **Firewall Form**:
   - Users input packet details (IP, port, protocol) and validate packets.
   - Custom rules can be added after successful admin authentication.
   - Default and custom rules can be viewed via pop-up message boxes.
4. **Admin Login Form**:
   - Ensures only authorized users can add custom rules.
   - Upon successful login, the Add Custom Rules Form is displayed.
5. **Add Custom Rules Form**:
   - Allows users to define rule parameters such as IP address, port, protocol, and decision.
   - Validates user input and updates the rule set accordingly.

## Limitations
1. **Authentication**: The application uses hardcoded admin credentials instead of a secure database-driven authentication system.
2. **Batch Operations**: Does not support batch processing of packets or rules.
3. **Database Integration**: Custom rules are stored in files instead of a database, limiting scalability and robustness.
4. **Platform Restriction**: The application is Windows-only due to its reliance on Windows Forms.
