@using JobBoard.Models;
@{
  Layout = "_Layout";
}
@if (Model.Count == 0)
{
  <p> There are no current entries in the list.</p>
}
<ul>
  @foreach(JobOpening job in Model)
  {
    <li>Job Title: @job.Title</li>
    <li>Job Description: @job.Description</li>
    <li>Contact Info:</li>
      <ul>
        <li>Name: @job.Poster.Name</li>
        <li>Email: @job.Poster.Email</li>
        <li>Phone: @job.Poster.PhoneNumber</li>
      </ul>
  }
</ul>
<button class="btn btn-success" type="button" name="goback" onclick="window.location.href='/'">Go Back</button>
