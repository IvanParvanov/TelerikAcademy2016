<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ViewSwitcher.ascx.cs" Inherits="_01_Random.ViewSwitcher" %>
<div id="viewSwitcher">
    <%: this.CurrentView %> view | <a href="<%: this.SwitchUrl %>" data-ajax="false">Switch to <%: this.AlternateView %></a>
</div>