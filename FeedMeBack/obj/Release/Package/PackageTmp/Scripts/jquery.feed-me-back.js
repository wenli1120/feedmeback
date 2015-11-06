(function($) {

	


	function stickToTop(options) {
	    var titleText = "Provide Feedback!";
	    var descriptionText = "Please provide your feedback:";

        if (options.title != null && options.title != "") {
            titleText = options.title;
        }

        if (options.description != null && options.description != "") {
            descriptionText = options.title;
        }

        //append the form 

        var form = "<div id='stickyFeedBackForm' style='position:absolute;left:-12px'>" +
        "<button id='stickyFeedBackFormToggle' type='button' class='btn btn-warning'>" +
            "<span id='stickyFeedBackFormTitle'>" + titleText + "</span> >" +
        "</button>" +
        "<div id='stickyFeedBackFormBody'>" +
            "<div class='well well-lg'>" +
                "<span>" + descriptionText + "</span>" +
                "<textarea id='feedback' style='width:100%;'></textarea>" +
                "<button id='stickyFeedBackFormSend' class='btn btn-warning right'>Send</button>" +
            "</div>" +
        "</div>" +
    "</div>";

        $("body").append(form);

        var title = $("#stickyFeedBackForm #stickyFeedBackFormTitle");
        var formBody = $("#stickyFeedBackForm #stickyFeedBackFormBody");

        title.hide();
        formBody.hide();

        $(window).scroll(function () {
            var scrollTop = $(window).scrollTop();
            var windowHeight = $(window).height();
            $("#stickyFeedBackForm").css('top', scrollTop + windowHeight - 232 + 'px');
        });


        $("#stickyFeedBackForm #stickyFeedBackFormToggle").click(function () {

            if (title.is(":visible")) {
                title.hide();
            } else {
                title.show();
            }

            if (formBody.is(":visible")) {
                formBody.hide();
            } else {
                formBody.show();
            }
        });


        $("#stickyFeedBackForm #stickyFeedBackFormSend").click(function () {

            var message = $("#stickyFeedBackForm #feedback").val();
            console.log(message);

            $.ajax({
                type: "POST",
                crossDomain: true,
                url:options.url,
                data: { Message: message, Key: options.key, UserName: options.userName },
                success: function (data) {
                    alert('New Feedback submitted. Id: ' + data.Id + '. Thank you!');
                }
            });
        });
    }
	$.fn.feedMeBack = function (options) {
	    stickToTop(options);
	};
}(jQuery));
