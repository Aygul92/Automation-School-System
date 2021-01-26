<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMasterPage.master" AutoEventWireup="true" CodeFile="ClassList.aspx.cs" Inherits="Default4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <style>
        .state-icon {
            left: -5px;
        }

        .list-group-item-primary {
            color: rgb(255, 255, 255);
            background-color: rgb(66, 139, 202);
        }

        /* DEMO ONLY - REMOVES UNWANTED MARGIN */
        .well .list-group {
            margin-bottom: 0px;
        }

        .trash {
            color: rgb(209, 91, 71);
        }

        .flag {
            color: rgb(248, 148, 6);
        }

        .panel-body {
            padding: 20px;
        }

        .panel-footer .pagination {
            margin: 0;
        }

        .panel .glyphicon, .list-group-item .glyphicon {
            margin-right: 50px;
        }

        .panel-body .radio, .checkbox {
            display: inline-block;
            margin: 0px;
        }

        .panel-body input[type=checkbox]:checked + label {
            text-decoration: line-through;
            color: rgb(128, 144, 160);
        }

        .list-group-item:hover, a.list-group-item:focus {
            text-decoration: none;
            background-color: rgb(245, 245, 245);
        }

        .list-group {
            margin-bottom: 50px;
        }

        .auto-style1 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 50%;
            left: 546px;
            top: 15px;
            padding-left: 10px;
            padding-right: 10px;
        }

        .auto-style2 {
            display: block;
            position: relative;
            left: -14px;
            top: 15px;
            margin: 10px 0px;
        }
    </style>

    <script type="text/javascript">
        $(function () {
            $('.list-group.checked-list-box .list-group-item').each(function () {

                // Settings
                var $widget = $(this),
                    $checkbox = $('<input type="checkbox" class="hidden" />'),
                    color = ($widget.data('color') ? $widget.data('color') : "primary"),
                    style = ($widget.data('style') == "button" ? "btn-" : "list-group-item-"),
                    settings = {
                        on: {
                            icon: 'glyphicon glyphicon-check'
                        },
                        off: {
                            icon: 'glyphicon glyphicon-unchecked'
                        }
                    };

                $widget.css('cursor', 'pointer')
                $widget.append($checkbox);

                // Event Handlers
                $widget.on('click', function () {
                    $checkbox.prop('checked', !$checkbox.is(':checked'));
                    $checkbox.triggerHandler('change');
                    updateDisplay();
                });
                $checkbox.on('change', function () {
                    updateDisplay();
                });


                // Actions
                function updateDisplay() {
                    var isChecked = $checkbox.is(':checked');

                    // Set the button's state
                    $widget.data('state', (isChecked) ? "on" : "off");

                    // Set the button's icon
                    $widget.find('.state-icon')
                        .removeClass()
                        .addClass('state-icon ' + settings[$widget.data('state')].icon);

                    // Update the button's color
                    if (isChecked) {
                        $widget.addClass(style + color + ' active');
                    } else {
                        $widget.removeClass(style + color + ' active');
                    }
                }

                // Initialization
                function init() {

                    if ($widget.data('checked') == true) {
                        $checkbox.prop('checked', !$checkbox.is(':checked'));
                    }

                    updateDisplay();

                    // Inject the icon if applicable
                    if ($widget.find('.state-icon').length == 0) {
                        $widget.prepend('<span class="state-icon ' + settings[$widget.data('state')].icon + '"></span>');
                    }
                }
                init();
            });

            $('#get-checked-data').on('click', function (event) {
                event.preventDefault();
                var checkedItems = {}, counter = 0;
                $("#check-list-box li.active").each(function (idx, li) {
                    checkedItems[counter] = $(li).text();
                    counter++;
                });
                $('#display-json').html(JSON.stringify(checkedItems, null, '\t'));
            });
        });

    

           });
       });



    </script>




</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cplPageContents" runat="Server">

    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="auto-style1">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <span class="glyphicon glyphicon-list"></span>Your Class
                        <div class="pull-right action-buttons">
                        </div>
                        </div>
                        <div class="panel-body">

                            <asp:Repeater ID="Sinifid" runat="server">
                                <ItemTemplate>
                                    <li class="list-group-item" data-id="<%#Eval("Id") %>"><%#Eval("Adi") %></li>
                                </ItemTemplate>
                            </asp:Repeater>


                        </div>
                        <div class="panel-footer">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

</asp:Content>

