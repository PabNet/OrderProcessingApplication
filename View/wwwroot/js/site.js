window.initializeDataTable = () => {
    $(dataTableId).DataTable();
}

window.initializeMultipleSelect = () => {
    $(multipleSelectProviderId).selectpicker();
    hideUnwantedElementsOnThePage(selectCaretId);
}

window.initializeSidebar = () => {
    document.body.classList.toggle(navBarToggle);
    sessionStorage.setItem(toggleItem, String(document.body.classList.contains(navBarToggle)));
}

window.initializeDateTimePickers = () => {
    let startDateValue = moment().subtract(countOfSubtractedFromTheDate, subtractedPartOfTheDate).format(dateFilterFormat);
    let endDateValue = moment().format(dateFilterFormat);
    
    $(startDateTimePickerId).val(startDateValue);
    $(endDateTimePickerId).val(endDateValue);
    
    return [startDateValue, endDateValue];
}

window.initializeChart = (chartType, labels, data) => {
    Chart.defaults.global.defaultFontFamily = chartFontFamily;
    Chart.defaults.global.defaultFontColor = chartColor;
    
    switch(chartType)
    {
        case lineChart:
        {
            initializeLineChart(labels, data);
            
            break;
        }
        case barChart:
        {
            initializeBarChart(labels, data);
            
            break;
        }
        case pieChart:
        {
            initializePieChart(labels, data);
            
            break;
        }
    }
}

window.showModal = (title, description) => {
    $(modalTitleId).text(title);
    $(modalDescriptionId).text(description);
    
    $(modalId).addClass(modalShowClass);
}

window.hideModal = () => {
    $(modalId).removeClass(modalShowClass);
}



