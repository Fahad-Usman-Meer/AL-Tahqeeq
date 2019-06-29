<div class="row urdu_center">
             
            <h1 class="urdu_center">
                <span class="label label-success">
                    متعلقہ اور اہم مضامین
                </span>
             </h1>   

            @{
                var list = Common.List_of_Urdu_Maslas;

                if (Session["currPage"] == null)
                {   Session["currPage"] = string.Empty;}
                
                foreach (var masla in list)
                {
                    if ( !masla.Key.Equals(Session["currPage"].ToString(), StringComparison.OrdinalIgnoreCase))
                    { 
                        var imgLocation = string.Format("~/images/Masla_icons/{0}_icon.jpg", masla.Key);
                        var maslaLink = string.Format("~/Masla/{0}", masla.Key);
                        
                        <a href="@Url.Content(maslaLink)">
                            <div class="col-md-4">
                                <blockquote>

                                    <img class="img-thumbnail" style="width:100%; height: 230px" src="@Url.Content(imgLocation)" />
                                    
                                    <h3 class="urdu_center"> @masla.Value </h3>
                                    
                                        @*<p>
                                        @* @Html.ActionLink("مزید پڑھیں۔۔۔", "GetView", "Masla", new { viewName = masla.Key }, new { @class = "btn btn-primary" })

                                        <label class="btn btn-default"> مزید پڑھیں۔۔۔  &raquo;</label>
                                    </p>*@
                                </blockquote>
                            </div>
                        </a>
                    }
                }
            }
        </div>