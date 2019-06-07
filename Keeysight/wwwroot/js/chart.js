function addData() {
    var user = document.getElementById("Label").value;
    var message = document.getElementById("Value").value;

    chart.data.labels.push(user);
    chart.data.datasets.forEach((datasets) => {
        datasets.data.push(message);
    });
    //chart.data.labels.splice(0, 1); // remove first label
    chart.update();
    //removeFirstOne();
}


function removeFirstOne()
{
    chart.data.labels.splice(0, 1); // remove first label
    chart.data.datasets.forEach(function (datasets) {
        datasets.data.splice(0, 1); // remove first data point
    });
    chart.update();


}
function removeData() {
    chart.data.labels.pop();
    chart.data.datasets.forEach((datasets) => {
        datasets.data.pop();
    });
    chart.update();
}

function sort()
{
}
