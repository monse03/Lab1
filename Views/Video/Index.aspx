<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Lista</title>
</head>
<body>
    <h1>Lista de videos: </h1>
    Existen <%:((System.Data.DataTable)ViewData["Video"]).Rows.Count %> videos
    <br />
    <%
        foreach (System.Data.DataRow ren in ((System.Data.DataTable)ViewData["Video"]).Rows)
        {%>
        <p> <%:ren["titulo"].ToString() %></p>
            
        <%}
     %>
</body>
</html>
