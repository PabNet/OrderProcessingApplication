function hideUnwantedElementsOnThePage(id) {
    $(id).remove();
}

function getStep(length) {
    return length === 0 ? 5 : length;
}

function getColorArray(length) {
    let colors = [];
    while (colors.length < length) {
        colors.push(`rgb(${rand(0, 255)}, ${rand(0, 255)}, ${rand(0, 255)})`);
    }
    
    function rand(frm, to) {
        return ~~(Math.random() * (to - frm)) + frm;
    }
    
    return colors;
}

function createChart(chartId, chartConfig) {
    new Chart(document.getElementById(chartId), chartConfig);
}

function initializeLineChart(labels, data) {
    createChart(lineChartId,{
        type: lineChart,
        data: {
            labels: labels,
            datasets: [{
                label: lineChartTitle,
                lineTension: 0.3,
                backgroundColor: "rgba(2,117,216,0.2)",
                borderColor: "rgba(2,117,216,1)",
                pointRadius: 5,
                pointBackgroundColor: "rgba(2,117,216,1)",
                pointBorderColor: "rgba(255,255,255,0.8)",
                pointHoverRadius: 5,
                pointHoverBackgroundColor: "rgba(2,117,216,1)",
                pointHitRadius: 50,
                pointBorderWidth: 2,
                data: data,
            }],
        },
        options: {
            scales: {
                xAxes: [{
                    gridLines: {
                        display: false
                    },
                }],
                yAxes: [{
                    ticks: {
                        min: 0,
                        max: getStep(data.length),
                        stepSize: 1
                    },
                    gridLines: {
                        color: "rgba(0, 0, 0, .125)",
                    }
                }],
            },
            legend: {
                display: false
            }
        }
    });
}

function initializePieChart(labels, data) {
    createChart(pieChartId, {
        type: pieChart,
        data: {
            labels: labels,
            datasets: [{
                data: data,
                backgroundColor: getColorArray(data.length),
            }],
        },
    });
}

function initializeBarChart(labels, data) {
    createChart(barChartId,{
        type: barChart,
        data: {
            labels: labels,
            datasets: [{
                label: barChartTitle,
                backgroundColor: "rgba(2,117,216,1)",
                borderColor: "rgba(2,117,216,1)",
                data: data,
            }],
        },
        options: {
            scales: {
                xAxes: [{
                    gridLines: {
                        display: false
                    },
                }],
                yAxes: [{
                    ticks: {
                        min: 0,
                        max: getStep(data.length),
                        stepSize: 1
                    },
                    gridLines: {
                        display: true
                    }
                }],
            },
            legend: {
                display: false
            }
        }
    });
}