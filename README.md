# Creating a WPF column chart dashboard to visualize the details of the 2024 T20 World Cup.

## Dashboard

Interpreting raw data can be a tedious and challenging task. However, visual representations such as charts and graphs make this process significantly easier and more intuitive. When these visual tools are enhanced with interactive features, understanding complex data becomes a piece of cake.

## Column Chart

[Column charts](https://www.syncfusion.com/wpf-controls/charts/wpf-column-chart) are useful for displaying changes in data over a specific period of time or for illustrating comparisons between different items.

## Customization

By default, column charts plot discrete rectangles for the given values. We can customize the shape of the series as desired using the [CustomTemplate](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ColumnSeries.html#Syncfusion_UI_Xaml_Charts_ColumnSeries_CustomTemplate) property. 

We can customize the color, border, and border width of the column segment using the [Interior](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeriesBase.html#Syncfusion_UI_Xaml_Charts_ChartSeriesBase_Interior) , [Stroke](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeries.html#Syncfusion_UI_Xaml_Charts_ChartSeries_Stroke), and [StrokeThickness](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeries.html#Syncfusion_UI_Xaml_Charts_ChartSeries_StrokeThickness) properties respectively.

## Watermark

We can add any view to the plot area using [Watermark](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.SfChart.html#Syncfusion_UI_Xaml_Charts_SfChart_Watermark) support, which is useful for adding any relevant data.

We all recently enjoyed the thrilling matches of the T20 World Cup. Cricket brings out a mix of emotions—joy, grace, and sometimes sadness—creating unforgettable moments for players and fans alike. Everyone has their favorite teams and players, and opinions vary widely.

This article explain how to create a rich dashboard to visualize data from the T20 World Cup 2024 using Syncfusion WPF Chart. Unlike typical applications, a dashboard transforms raw data into visually appealing and easily understandable formats. We will specifically focus on visualizing country-wise T20 data using a combo box selection for an interactive experience.

The following chart visually presents the discussed data, offering a clear comparison of the T20 World Cup 2024 data, allowing you to gain insights at a glance.

# Output 
<img width="945" alt="Image" src="https://github.com/user-attachments/assets/46176ae1-7f8d-421e-8e21-d82f9be85e80">

## Troubleshooting

#### Path too long exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

For a step-by-step procedure, refer to the [2024 - T20 Blog](https://www.syncfusion.com/blogs/post/wpf-charts-2024-t20-world-cup-data).
