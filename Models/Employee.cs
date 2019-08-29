using System;

namespace OrderTracker.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string PhotoPath { get; set; }
    }

}

//// in startup make sure that app.UseStaticFiles(); is being used.

//// add public string PhotoPath { get; set; } to userprofile class

/// in ViewModels make a UserProfileViewModel.cs page, inside of it use the same fields as you have in the model class except dont include the actual ID and instead of photopath add "public IFormFile Photo {get; set;}

//next go inside of the UserProfileController page and add added the obvious statements at the top and everythign inside of the create method()

// just need to add views, in the details and create view. 
// at the top of the create view you need to add the @using the namespace of the userprofileviewmodel page. and also add @model of the class youre using on the userprofileviewmodel page
//everything else on the create page is easy to see

//on the details page which is the page were showing the image you have the to have using and model statement at the top and the other key take aways are you need to have the var photopath and the src="@url.Content(@PhotoPath) 
