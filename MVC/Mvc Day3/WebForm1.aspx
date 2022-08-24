﻿
@{
    ViewBag.Title = "Index";
}

<h2>Index</h2>

<div class="container">
    <h3>Student Registration Form: </h3>
    @Html.ActionLink("Go to About", "About", new { })
    @Html.Hidden("StudentId", "100")
    @using (Html.BeginForm("Index", "Home", FormMethod.Post))
    {
        <div>
            <table border="1" class="table table-bordered" style="background-color:antiquewhite;width:500px;">
                <tbody>
                    <tr>
                        <td>
                            @Html.Label("User Name ")
                        </td>
                        <td>
                            @Html.TextBox("txtUserName", "", new { @class = "form-control" })
                        </td>
                    </tr>
                    <tr>
                        <td>
                            @Html.Label("Password", "Password")
                        </td>
                        <td>
                            @Html.Password("Password", "", new { @class = "form-control" })
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Gender:
                        </td>
                        <td>
                            @Html.RadioButton("Gender", "Male", true, new { id = "male" }) Male
                            @Html.RadioButton("Gender", "Female", false, new { id = "female" }) Female
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Address:
                        </td>
                        <td>
                            @Html.TextArea("Address", " ", new { @class = "form-control", id = "IdAddress" })
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Hobbies :
                        </td>
                        <td>
                            @Html.CheckBox("Cricket", true) Cricket
                            @Html.CheckBox("Dancing") Dancing
                            @Html.CheckBox("Drawing") Drawing

                        </td>
                    </tr>

                    <tr>
                        <td>
                            Courses:
                            @{
                                IEnumerable<string> strList = new List<string> { "BCA", "BE", "MCA", "MCS" };
                            }
                        </td>
                        <td>
                            @Html.DropDownList("ddlCourse", new SelectList(strList, strList.FirstOrDefault()), "--Select Course----")
                        </td>
                    </tr>
                    <tr>
                        <td>Skills</td>
                        <td>
                            @Html.ListBox("Select Skills", new List<SelectListItem> {
                           new SelectListItem{Text= "C#",Value="1"},
                           new SelectListItem{ Text="ASP.NET",Value="2" },
                           new SelectListItem{ Text="ASP.NET Core",Value="3" },
                           new SelectListItem{ Text="Azure",Value="4" }
                            })
                        </td>

                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                            <input type="submit" class="btn-primary" />
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    }
</div>