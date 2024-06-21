# FormClone Frontend
## Overview
FormClone Frontend is a Windows Forms application that allows users to submit, view, edit, and delete form submissions. It interacts with a backend API to perform CRUD operations on submission data.

## Features
- Start and stop a stopwatch timer.
- Submit form data including name, email, phone number, GitHub link, and stopwatch time.
- View submitted data.
- Edit existing submissions.
- Delete submissions.
- Navigate through submissions.
- Keyboard shortcuts for Buttons.

## Prerequisites
- .NET Framework (v4.7.2 or later)
- Visual Studio or any other compatible IDE
- Backend API running on http://localhost:3000

##Setup

1. Clone the Repository:

```bash
git clone https://github.com/AyushBarai/SlidelyAI_Frontend_vb.git
cd formclone-frontend
```
2. Open the Project:

Open the project in Visual Studio.

3. Configure the Backend URL:

Ensure the backend API is running on http://localhost:3000. If it's different, update the URL in the code.

4. Build the Project:

Build the project using Visual Studio.

5. Run the Application:

Run the application using Visual Studio.

## Code Structure

### Main Files
- Form1.vb: Main form with submission features.
- Form2.vb: Form for viewing and navigating through submissions.
- Form3.vb: Form for creating a new submission.
- Form4.vb: Form for editing an existing submission.

### API Endpoints
- POST /submit: Submits a new form entry.
- GET /read?index={index}: Retrieves a specific submission by index.
- POST /update?index={index}: Updates a specific submission by index.
- GET /count: Retrieves the total number of submissions.
- DELETE /delete?index={index}: Deletes a specific submission by index.
