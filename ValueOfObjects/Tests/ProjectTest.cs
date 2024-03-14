using ValueOfObjects.Models;

namespace ValueOfObjects.Tests;

public class ProjectTest : BaseTest
{
    [Test]
    public void SuccessfulAddProjectTest()
    {
        _navigationSteps.SuccessfulLogin(Admin);

        /*
        Project expectedProject = new Project()
        {
            ProjectName = "WP Test 01",
            Announcement = "Test Details",
            IsShowAnnouncement = false,
            ProjectType = 1
        };
        */

        Assert.That(_projectSteps.AddProject(project).SuccessMessage.Text.Trim(),
            Is.EqualTo("Successfully added the new project."));
    }
}