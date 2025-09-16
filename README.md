# Laboratory 4

# Task 1 – Creating the Project

Razor Pages

# Task 2 – Displaying Images from the Server

The `Index` model was modified to handle OS-dependent paths.  
Additionally, functionality was added to display file names from the `/wwwroot/images` directory.


# Task 3 – Form for Uploading Images

A form was added to handle file uploads.  
Additionally, the `OnPost()` method was implemented to process the submitted files.


# Task 4 – Adding a Button to the Subpage with the Form

A link was added to navigate to the upload form page:

<a asp-page="Upload">Upload new file...</a>

# Task 5 – Displaying Images

Instead of displaying file names, the images are now shown one below the other, centered on the page.

# Task 6 – Displaying a Single Image

A view for a single image has been added. Each image in the gallery now includes a hyperlink to view that specific image in full resolution.

# Task 7 – Watermarks

The image `watermark.png` is used to add a watermark to uploaded images.



# File Upload Adjustment

I encountered issues with uploading files to the server using the previous code, so I modified the task.  
In my setup, there are three directories:

- `images` – stores original images without watermark  
- `gallery` – stores images with watermark; these are displayed on the website  
- `watermark` – contains only `watermark.png`

