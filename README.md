# Blood Donor

Blood Donor is a desktop application developed in C# using the .NET framework, and it uses a SQL database for data storage. This software facilitates the process of finding blood donors and managing user information efficiently.

## Features

### User Registration and Login
- Users can register by providing their personal details including mobile number, email, city, gender, and blood group.
- Upon successful registration, users can log in to the system.

### Blood Donor List
- Logged-in users can view a list of available blood donors.
- Clicking on a donor from the list will display their profile with the following details:
  - Mobile Number
  - Email
  - City
  - Gender
  - Blood Group

### Search Functionality
- Users can search for donors by blood group, city, or both.
- This makes it easy to find donors who match specific criteria.

### Verification
- User email addresses and phone numbers are verified via email and SMS respectively.
- This ensures the authenticity of the contact information provided.

### Password Recovery
- If a user forgets their password, they can recover it by searching using their email or phone number.
- Password recovery is verified through both email and SMS, allowing users to reset their password securely.

### Data Integrity
- All user email addresses and phone numbers are unique in the database to prevent duplicates and ensure accurate information.

## Technology Stack
- *Programming Language:* C#
- *Framework:* .NET
- *Database:* SQL

## Installation

1. *Clone the repository:*
   ```sh
   git clone https://github.com/basharul2002/Blood-Donor.git


2. Navigate to the project directory:
```sh
cd blood-donor
```

3. Build the project: Open the solution file (.sln) in Visual Studio and build the project.

4. Set up the database:
    - Create a new SQL database.
    - Run the provided SQL scripts to set up the necessary tables and constraints

5. Configure the application:
    - Update the connection string in the app.config file with your database details.
    
6. Run the application: Start the application from Visual Studio or the executable file created after building the project.

## Usage
1. Register:
    - Open the application and complete the registration form.
    - Verify your email and phone number.
2. Login:
    - Use your credentials to log in to the system.

3. Search for Donors:
    - Use the search functionality to find donors by blood group, city, or both.

4. View Donor Profiles:
    - Click on a donor from the list to view their profile details.

5. Password Recovery:
    - If you forget your password, use the password recovery feature to reset it via email or SMS verification.
    
## Contributions
Contributions are welcome! Please submit a pull request or open an issue to discuss your ideas.

## License
    This project is licensed under the MIT License - see the LICENSE file for details.

## Contact
    For any inquiries or support, please contact: Email: basharulalam6@gmail.com
    Thank you for using Blood Donor! Your contributions and feedback are highly appreciated.
