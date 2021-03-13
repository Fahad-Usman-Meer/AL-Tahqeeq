

$(document).on('mouseenter', '.glyphicon-link', function () {
    $(this).attr('title', 'Click to Copy Link');
});//.on('mouseleave', '.asd', function () { });

$(document).on('click', '.glyphicon-link', function () {

    var linkToCopy = $(this).parent("a").attr('href'); // children("a").attr('href');
    copyToClipboard(linkToCopy);

    //document.location = linkToCopy;
    //OpenSpecificHeadingFromUrl();
    ////alert("copied");
});

//var flagClickAgain = 0;


$(document).on('click', '.internal-link', function () {

    document.location = $(this).attr('href');

    //alert("new document.URL = " + document.URL);
    //alert("internal link clicked : document.URL = " + document.URL + " \n\n Windows.location = " + window.location);

    OpenSpecificHeadingFromUrl();
    

    //alert("at the end :" );

    ////location.reload();
});

function OpenSpecificHeadingFromUrl() {

    var currURL = (window.location).toString();// document.URL;
    //alert("this is calling : " + currURL);

    if (currURL != null && currURL.length > 0)
    {
        //alert("here : " + currURL);
        var array = currURL.split('#');

        if (array != null && array.length > 1)
        {
            var heading = array[1];
            var specificDivId = array[2];
           // alert("Heading : " + heading);
            var questionMarks = "?_?_?_";
            var headingId = (heading.replace(questionMarks, "")).replace(/-/g, '_');
            headingId = '#' + headingId;
            //alert("Conveted Heading Id : " + headingId);

            var parentDiv = $(headingId).parent();
            //alert(parentDiv.find('.glyphicon-sort').html());

            if (parentDiv.find('div.collapse').hasClass('collapse')) {
              //  alert("Collapsed");
                parentDiv.find('.glyphicon-sort').click();
            }
            //else  // heading is already opened
            //{
            //    //alert("Not Collapsed!!!");
            //}

            if (specificDivId != null)
            {
                $('html, body').animate({
                    scrollTop: $("div #" + specificDivId).offset().top
                }, 2000);
            }
            else
            {
                specificDivId = headingId;
            //alert("specific div id : " + specificDivId);

                $('html, body').animate({
                    scrollTop: $("div " + specificDivId).offset().top
                }, 2000);
            }
            //alert("specific div id : " + specificDivId);

            //{
               // //alert("array[0] : " + array[0] );
                // //alert("specificDivId : " + specificDivId );
                // // location.href = array[0] + "#" + specificDivId;
               // var newUrl = array[0] + "#" + specificDivId;
               // window.location = newUrl;  // it is compulsory
               // ////location.replace(newUrl);
                // // alert("final : " + newUrl);

               // alert("Noww : going to specificDivId : " + specificDivId);


               // alert("At specificDivId : " + specificDivId);
            //}



        }
    }
}

function copyToClipboard(text) {

    //text = window.location.href // + text;

    var $temp = $("<input>");
    $("body").append($temp);
    $temp.val(text).select();
    document.execCommand("copy");
    $temp.remove();

    ShowToast(document.getElementById("copiedToClipboard"));
}


function ShowToast(element) {
    var x = element;
    x.className = "show";
    setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
}


function sleep(milliseconds) {
    var start = new Date().getTime();
    for (var i = 0; i < 1e7; i++) {
        if ((new Date().getTime() - start) > milliseconds) {
            break;
        }
    }
}

//**** Open/Close All Headings

function open_close_all_headingsClick() {
    //alert("asdasd");

    /** 'collapse' property is skipped when we Manually click on heading
    *   So, Add this class first. **/
    //$('div.panel-collapse').each(function (index) {
    //    if (!$(this).hasClass('collapse')) {
    //        $(this).addClass('collapse');
    //    }
    //});


    var state = $("#open_close_all_headings").attr('state');

    if (state == "close") {
        //$(".open").addClass("in").removeClass("open");

        $('div.panel-collapse').addClass('in').css("height", "");
        $('div.panel-collapse').removeClass('collapse').css("height", "");

        $("#open_close_all_headings").attr('state', "open");
        $("#open_close_all_headings").text("Close all Headings");
    }
    else {
        //$(".in").addClass("open").removeClass("in");

        $('div.panel-collapse').removeClass('in');
        $('div.panel-collapse').addClass('collapse');

        $("#open_close_all_headings").attr('state', "close");
        $("#open_close_all_headings").text("Open all Headings");
    }

}

// ===== Scroll to Top ==== 
$(window).scroll(function () {

    if ($(this).scrollTop() >= 500)        // If page is scrolled more than 500px
    {
        // Fade in the arrow
        $('#return_to_top').fadeIn(100).fadeOut(1);
    }
    else {
        $('#return_to_top').fadeOut(1);   // Else fade out the arrow
    }

});
$(document).on('click', '#return_to_top', function () {
    //alert("new click");
    $('body,html').animate({
        scrollTop: 0                       // Scroll to top of body
    }, 5000);

});