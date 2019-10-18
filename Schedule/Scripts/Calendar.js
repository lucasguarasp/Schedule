$(document).ready(function () {
    var events = [];
    var selectedEvent = null;
    FetchEventAndRenderCalendar();
    function FetchEventAndRenderCalendar() {
        events = [];
        $.ajax({
            type: "GET",
            url: "/home/GetEvents",
            success: function (data) {
                $.each(data, function (i, v) {
                    events.push({
                        eventID: v.id,
                        title: v.name,
                        nascimento: v.dtBirth != null ? moment(v.dtBirth) : null,
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
            eventLimit: true,
            eventColor: '#378006',
            events: events,
            eventClick: function (calEvent, jsEvent, view) {
                selectedEvent = calEvent;
                $('#myModal #eventTitle').text(calEvent.title);
                var $description = $('<div/>');
                $description.append($('<p/>').html('<b>Birth:</b>' + calEvent.nascimento.format('DD-MMM-YYYY')));
                $description.append($('<p/>').html('<b>Start:</b>' + calEvent.start.format("DD-MMM-YYYY HH:mm a")));
                if (calEvent.end != null) {
                    $description.append($('<p/>').html('<b>End:</b>' + calEvent.end.format("DD-MMM-YYYY HH:mm a")));
                }
                $description.append($('<p/>').html('<b>Description:</b>' + calEvent.description));
                $('#myModal #pDetails').empty().html($description);

                $('#myModal').modal();
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
                    End: event.end != null ? event.end.format('DD/MM/YYYY HH:mm A') : null,
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
                type: "POST",
                url: '/home/DeleteEvent',
                data: { 'eventID': selectedEvent.eventID },
                success: function (data) {
                    if (data.status) {
                        //Refresh the calender
                        FetchEventAndRenderCalendar();
                        $('#myModal').modal('hide');
                    }
                },
                error: function () {
                    alert('Failed');
                }
            })
        }
    })

    $('#dtp1,#dtp2').datetimepicker({
        format: 'DD/MM/YYYY HH:mm A'
    });

    function openAddEditForm() {
        if (selectedEvent != null) {
            $('#Id').val(selectedEvent.eventID);
            $('#txtNome').val(selectedEvent.title);
            $('#txtNascimento').val(new Date().toLocaleDateString());
            $('#txtStart').val(selectedEvent.start.format('DD/MM/YYYY HH:mm'));
            $('#txtEnd').val(selectedEvent.end != null ? selectedEvent.end.format('DD/MM/YYYY HH:mm') : '');
            $('#txtDescription').val(selectedEvent.description);
        }
        $('#myModal').modal('hide');
        $('#myModalSave').modal();
    }

    $('#btnSave').click(function () {
        //Validation/
        if ($('#txtNome').val().trim() == "") {
            alert('Name required');
            return;
        }
        if ($('#txtStart').val().trim() == "") {
            alert('Birth date required');
            return;
        }
        if ($('#txtStart').val().trim() == "") {
            alert('Start date required');
            return;
        }
        if ($('#txtStart').val().trim() == "") {
            alert('End date required');
            return;
        }
        //if ($('#chkIsFullDay').is(':checked') == false && $('#txtEnd').val().trim() == "") {
        //    alert('End date required');
        //    return;
        //}
        else {
            var startDate = moment($('#txtStart').val(), "DD/MM/YYYY HH:mm A").toDate();
            var endDate = moment($('#txtEnd').val(), "DD/MM/YYYY HH:mm A").toDate();
            //var nascimento = moment($('#txtNascimento').val(), "DD/MM/YYYY").toDate();
            if (startDate > endDate) {
                alert('Invalid end date');
                return;
            }
        }

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
            type: "POST",
            url: '/home/SaveEvent',
            data: data,
            success: function (data) {
                if (data.status) {
                    //Refresh the calender
                    FetchEventAndRenderCalendar();
                    $('#myModalSave').modal('hide');
                }
            },
            error: function () {
                alert('Já existe uma agenda marcada nesse dia e horario');
            }
        })
    }
})