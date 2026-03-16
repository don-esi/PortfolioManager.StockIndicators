//     Ooples Finance Stock Indicator Library
//     https://ooples.github.io/StockIndicators/
//
//     Copyright © Franklin Moormann, 2020-2022
//     cheatcountry@gmail.com
//
//     This library is free software and it uses the Apache 2.0 license
//     so if you are going to re-use or modify my code then I just ask
//     that you include my copyright info and my contact info in a comment

global using StockIndicators.Enums;
global using StockIndicators.Exceptions;
global using StockIndicators.Models;
global using static StockIndicators.Helpers.MathHelper;
global using static StockIndicators.Helpers.SignalHelper;
global using static StockIndicators.Helpers.CalculationsHelper;
global using MathNet.Numerics;
global using MathNet.Numerics.Statistics;
global using LinqOptimizer.CSharp;
global using System.Globalization;
global using StockIndicators.Helpers;
global using System.Runtime.Serialization;
global using StockIndicators.Interfaces;