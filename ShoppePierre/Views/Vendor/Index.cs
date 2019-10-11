@using ShoppePierre.Models;
@{
  Layout = "_Layout";
}
@if (Model.Count == 0)
{
  <p> There are no current entries in the list.</p>
}
<ul>
  @foreach(Vendor Vendor in Model)
  {
    <li>Vendor Title: @Vendor.Title</li>
    <li>Vendor Description: @Vendor.Description</li>
    <li>Order Info:</li>
      <ul>
        <li>OrderNumber: @Vendor.OrderId.OrderNumber</li>
        <li>Name: @Vendor.OrderId.Name</li>
        <li>Email: @Vendor.OrderId.Email</li>
      </ul>
  }
</ul>
<button class="btn btn-success" type="button" name="goback" onclick="window.location.href='/'">Go Back</button>
