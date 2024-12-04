set title "Dynamic Density Contour (Path 1 ) Unit: veh/mile/lane" 
set xlabel "Time Horizon"
set ylabel "Space (Node Sequence)"  offset -1
set xtics (" 7:00" 0 ," 7:10" 10 ," 7:20" 20 ," 7:30" 30 ," 7:40" 40 ," 7:50" 50 ," 8:00" 60 ) 
set ytics ("South College Avenue" 0, "East University Drive" 6342, "South McAllister Avenue" 7861, "South McAllister Avenue" 9662, " " 16680)
set xrange [0:61] 
set yrange [0:16680] 
set palette defined (0 "white", 10 "green", 30 "yellow", 50 "red")
set pm3d map
splot 'D:\ASU Academics\Transportation Modelling and Simulation\TAPLite\export_path_density.txt' matrix notitle