#pragma checksum "C:\Users\lucas\OneDrive\Área de Trabalho\Schedule2\Schedule\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2046477482b016ae0f13f44fdbcd7dcbc3ccc83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\lucas\OneDrive\Área de Trabalho\Schedule2\Schedule\Views\_ViewImports.cshtml"
using Schedule;

#line default
#line hidden
#line 2 "C:\Users\lucas\OneDrive\Área de Trabalho\Schedule2\Schedule\Views\_ViewImports.cshtml"
using Schedule.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2046477482b016ae0f13f44fdbcd7dcbc3ccc83", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10cd76cd13e75e78b888fdb138509e2f1500f7c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-12 form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\lucas\OneDrive\Área de Trabalho\Schedule2\Schedule\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 1718, true);
            WriteLiteral(@"
<div class=""row"">
    <h2>Agenda Cadastro</h2>
</div>

<div id=""calender""></div>

<div id=""myModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title""><span id=""eventTitle""></span></h4>
            </div>
            <div class=""modal-body"">
                <button id=""btnDelete"" class=""btn btn-default btn-sm pull-right"">
                    <span class=""glyphicon glyphicon-remove""></span> Remover
                </button>
                <button id=""btnEdit"" class=""btn btn-default btn-sm pull-right"" style=""margin-right:5px;"">
                    <span class=""glyphicon glyphicon-pencil""></span> Editar
                </button>
                <p id=""pDetails""></p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn ");
            WriteLiteral(@"btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<!-- Modal Save-->
<div class=""modal fade"" id=""myModalSave"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Salvar Agenda</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""col-lg-12"">
                ");
            EndContext();
            BeginContext(1763, 2072, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92feab47e6d44441b2d543a35b924408", async() => {
                BeginContext(1803, 2025, true);
                WriteLiteral(@"
                    <input type=""hidden"" id=""Id"" value=""0"" />
                    <div class=""form-group"">
                        <label>Nome</label>
                        <input type=""text"" id=""txtNome"" class=""form-control"" />
                    </div>

                    <div class=""form-group"">
                        <label>Data de nascimento</label>
                        <div class=""input-group date"" id=""dtNascimento"">
                            <input type=""text"" id=""txtNascimento"" class=""form-control"" />
                            <span class=""input-group-addon"">
                                <span class=""glyphicon glyphicon-calendar""></span>
                            </span>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label>Data e hora inicial</label>
                        <div class=""input-group date"" id=""dtp1"">
                            <input type=""text"" id=""txtStart"" class=""fo");
                WriteLiteral(@"rm-control"" />
                            <span class=""input-group-addon"">
                                <span class=""glyphicon glyphicon-calendar""></span>
                            </span>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label>Data e hora Final</label>
                        <div class=""input-group date"" id=""dtp2"">
                            <input type=""text"" id=""txtEnd"" class=""form-control"" />
                            <span class=""input-group-addon"">
                                <span class=""glyphicon glyphicon-calendar""></span>
                            </span>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label>Observações</label>
                        <textarea id=""txtDescription"" rows=""3"" class=""form-control""></textarea>
                    </div>

                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3835, 682, true);
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" id=""btnSave"" class=""btn btn-success"">Save</button>
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<link href=""//cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.min.css"" rel=""stylesheet"" />
<link href=""//cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.print.css"" rel=""stylesheet"" media=""print"" />
<link href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.47/css/bootstrap-datetimepicker.min.css"" rel=""stylesheet"" />
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4534, 8393, true);
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.18.1/moment.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.47/js/bootstrap-datetimepicker.min.js""></script>
    <script>
        $(document).ready(function () {
            var events = [];
            var selectedEvent = null;
            FetchEventAndRenderCalendar();
            function FetchEventAndRenderCalendar() {
                events = [];
                $.ajax({
                    type: ""GET"",
                    url: ""/home/GetEvents"",
                    success: function (data) {
                        $.each(data, function (i, v) {
                            events.push({
                                eventID: v.id,
                                title: v.name,
                                nascimento: v.dtBirth != null ?");
                WriteLiteral(@" moment(v.dtBirth) : null,
                                start: moment(v.dtStart),
                                end: v.dtExit != null ? moment(v.dtExit) : null,
                                description: v.description
                            });
                        })

                        GenerateCalender(events);
                    },
                    error: function (error) {
                        alert('failed');
                    }
                })
            }

            function GenerateCalender(events) {
                $('#calender').fullCalendar('destroy');
                $('#calender').fullCalendar({
                    contentHeight: 400,
                    defaultDate: new Date(),
                    timeFormat: 'h(:mm)a',
                    header: {
                        left: 'prev,next today',
                        center: 'title',
                        right: 'month,basicWeek,basicDay,agenda'
                    },
           ");
                WriteLiteral(@"         eventLimit: true,
                    eventColor: '#378006',
                    events: events,
                    eventClick: function (calEvent, jsEvent, view) {
                        selectedEvent = calEvent;
                        $('#myModal #eventTitle').text(calEvent.title);
                        var $description = $('<div/>');
                        $description.append($('<p/>').html('<b>Birth:</b>' + calEvent.nascimento.format('DD-MMM-YYYY')));
                        $description.append($('<p/>').html('<b>Start:</b>' + calEvent.start.format(""DD-MMM-YYYY HH:mm a"")));
                        if (calEvent.end != null) {
                            $description.append($('<p/>').html('<b>End:</b>' + calEvent.end.format(""DD-MMM-YYYY HH:mm a"")));
                        }
                        $description.append($('<p/>').html('<b>Description:</b>' + calEvent.description));
                        $('#myModal #pDetails').empty().html($description);

                      ");
                WriteLiteral(@"  $('#myModal').modal();
                    },
                    selectable: true,
                    select: function (start, end) {
                        selectedEvent = {
                            eventID: 0,
                            title: '',
                            description: '',
                            start: start,
                            end: end,
                            allDay: false,
                            color: ''
                        };
                        openAddEditForm();
                        $('#calendar').fullCalendar('unselect');
                    },
                    editable: true,
                    eventDrop: function (event) {
                        var data = {
                            EventID: event.eventID,
                            Subject: event.title,
                            Start: event.start.format('DD/MM/YYYY HH:mm A'),
                            End: event.end != null ? event.end.format('DD/MM/");
                WriteLiteral(@"YYYY HH:mm A') : null,
                            Description: event.description,
                            ThemeColor: event.color,
                            IsFullDay: event.allDay
                        };
                        SaveEvent(data);
                    }
                })
            }

            $('#btnEdit').click(function () {
                //Open modal dialog for edit event
                openAddEditForm();
            })
            $('#btnDelete').click(function () {
                if (selectedEvent != null && confirm('Você tem certeza?')) {
                    $.ajax({
                        type: ""POST"",
                        url: '/home/DeleteEvent',
                        data: { 'eventID': selectedEvent.eventID },
                        success: function (data) {
                            if (data.status) {
                                //Refresh the calender
                                FetchEventAndRenderCalendar();
               ");
                WriteLiteral(@"                 $('#myModal').modal('hide');
                            }
                        },
                        error: function () {
                            alert('Failed');
                        }
                    })
                }
            })

            $('#dtp1,#dtp2').datetimepicker({
                format: 'DD/MM/YYYY HH:mm'
            });

            $('#dtNascimento').datetimepicker({
                format: 'DD/MM/YYYY'
            });

            function openAddEditForm() {
                if (selectedEvent != null) {
                    $('#Id').val(selectedEvent.eventID);
                    $('#txtNome').val(selectedEvent.title);
                    $('#txtNascimento').val(new Date().toLocaleDateString());
                    $('#txtStart').val(selectedEvent.start.format('DD/MM/YYYY HH:mm'));
                    $('#txtEnd').val(selectedEvent.end != null ? selectedEvent.end.format('DD/MM/YYYY HH:mm') : '');
                    $('#txtDe");
                WriteLiteral(@"scription').val(selectedEvent.description);
                }
                $('#myModal').modal('hide');
                $('#myModalSave').modal();
            }

            $('#btnSave').click(function () {
                //Validation/
                if ($('#txtNome').val().trim() == """") {
                    alert('Name required');
                    return;
                }
                if ($('#txtStart').val().trim() == """") {
                    alert('Start date required');
                    return;
                }
                if ($('#txtEnd').val().trim() == """") {
                    alert('End date required');
                    return;
                }

                var startDate = moment($('#txtStart').val(), ""DD/MM/YYYY HH:mm A"").toDate();
                var endDate = moment($('#txtEnd').val(), ""DD/MM/YYYY HH:mm A"").toDate();
                if (startDate > endDate) {
                    alert('Invalid end date');
                    return;

      ");
                WriteLiteral(@"          }

                var data = {
                    Id: $('#Id').val(),
                    Name: $('#txtNome').val().trim(),
                    DtBirth: $('#txtNascimento').val().trim(),
                    DtStart: $('#txtStart').val().trim(),
                    DtExit: $('#txtEnd').val().trim(),
                    Description: $('#txtDescription').val()
                }
                SaveEvent(data);
                // call function for submit data to the server
            })

            function SaveEvent(data) {
                $.ajax({
                    type: ""POST"",
                    url: '/home/SaveEvent',
                    data: data,
                    success: function (data) {
                        if (data.status) {
                            //Refresh the calender
                            FetchEventAndRenderCalendar();
                            $('#myModalSave').modal('hide');
                        }
                    },
            ");
                WriteLiteral("        error: function () {\r\n                        alert(\'Já existe uma agenda marcada nesse dia e horario\');\r\n                    }\r\n                })\r\n            }\r\n        })\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
