set title "Space time trajectory diagram"
set xlabel "Time Horizon"
set ylabel "Space (distance)"  offset -1
set xtics (" 7:00" 0 ," 7:10" 10 ," 7:20" 20 ," 7:30" 30 ," 7:40" 40 ," 7:50" 50 ," 8:00" 60 ) 
set ytics (" " 536870912)
set xrange [0:61] 
set yrange [0:1667.42] 
plot "agent1.txt" using 1:2 title 'agent 1'  with lines,\
"agent2.txt" using 1:2 title 'agent 2'  with lines,\
"agent3.txt" using 1:2 title 'agent 3'  with lines,\
"agent4.txt" using 1:2 title 'agent 4'  with lines
