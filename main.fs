open System

let a = 1.0
let b = 2.0

let y x = Math.Log(x) / x

printfn "Введіть N: "
let N = int (Console.ReadLine())

let h = (b - a) / float N

let xs = seq { for i in 0 .. N do yield a + float i * h }

let ys = xs |> Seq.map y

let xmax = ys |> Seq.max
let ymax = xs |> Seq.maxBy y
let xmin = ys |> Seq.min
let ymin = xs |> Seq.minBy y

printfn "x(max) = %f" xmax
printfn "y(min) = %f" ymin
printfn "y(max) = %f" ymax
printfn "x(min) = %f" xmin

let sum1 = xmax + ymin
let sum2 = ymax + xmin

printfn "x(max) + y(min) = %f" sum1
printfn "y(max) + x(min) = %f" sum2

if sum1 > sum2 then
  printfn "x(max) + y(min) > y(max) + x(min)"
else
  printfn "y(max) + x(min) > x(max) + y(min)"
