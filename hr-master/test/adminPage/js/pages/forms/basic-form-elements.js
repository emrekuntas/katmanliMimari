$(function () {
    //Textarea auto growth
    autosize($('textarea.auto-growth'));

    //Datetimepicker plugin
    $('.datetimepicker').bootstrapMaterialDatePicker({
        format: 'dddd DD MMMM YYYY - HH:mm',
        clearButton: true,
        weekStart: 1
    });

    $('.datepicker').bootstrapMaterialDatePicker({
        format: 'dddd DD MMMM YYYY',
        clearButton: true,
        weekStart: 1,
        time: false
    });

    $('.timepicker').bootstrapMaterialDatePicker({
        format: 'HH:mm',
        clearButton: true,
        date: false
    });

    //Bootstrap datepicker plugin
    $('#bs_datepicker_container input').datepicker({
        autoclose: true,
        container: '#bs_datepicker_container'
    });

    $('#bs_datepicker_container1 input').datepicker({
        autoclose: true,
        container: '#bs_datepicker_container1'
    });
    $('#bs_datepicker_container2 input').datepicker({
        autoclose: true,
        container: '#bs_datepicker_container2'
    });
    $('#bs_datepicker_container3 input').datepicker({
        autoclose: true,
        container: '#bs_datepicker_container3'
    });
    $('#bs_datepicker_container4 input').datepicker({
        autoclose: true,
        container: '#bs_datepicker_container4'
    });
    $('#bs_datepicker_container5 input').datepicker({
        autoclose: true,
        container: '#bs_datepicker_container5'
    });
    $('#bs_datepicker_container6 input').datepicker({
        autoclose: true,
        container: '#bs_datepicker_container6'
    });
    $('#bs_datepicker_container7 input').datepicker({
        autoclose: true,
        container: '#bs_datepicker_container7'
    });
    $('#bs_datepicker_container8 input').datepicker({
        autoclose: true,
        container: '#bs_datepicker_container8'
    });
    $('#bs_datepicker_container9 input').datepicker({
        autoclose: true,
        container: '#bs_datepicker_container9'
    });
    $('#bs_datepicker_container10 input').datepicker({
        autoclose: true,
        container: '#bs_datepicker_container10'
    });
    
    $('#bs_datepicker_component_container').datepicker({
        autoclose: true,
        container: '#bs_datepicker_component_container'
    });
    //
    $('#bs_datepicker_range_container').datepicker({
        autoclose: true,
        container: '#bs_datepicker_range_container'
    });
});