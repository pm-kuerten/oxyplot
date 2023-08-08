﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestModels.cs" company="OxyPlot">
//   Copyright (c) 2014 OxyPlot contributors
// </copyright>
// <summary>
//   Provides methods to create test models.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OxyPlot.Tests
{
    using OxyPlot.Series;
    using System;

    /// <summary>
    /// Provides methods to create test models.
    /// </summary>
    public static class TestModels
    {
        /// <summary>
        /// Creates a simple sin(x) function series plot model.
        /// </summary>
        /// <returns>A plot model.</returns>
        public static PlotModel CreateTestModel1()
        {
            var model = new PlotModel { Title = "Test 1" };
            model.Series.Add(new FunctionSeries(Math.Sin, 0, Math.PI * 8, 200, "sin(x)"));
            return model;
        }
    }
}