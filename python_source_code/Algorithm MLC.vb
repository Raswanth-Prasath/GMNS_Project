algorithm modified label-correcting
begin
    d(s) := 0 and pred(s) := 0;
    d(j) := ∞ for each node j ∈ N-{s};
    LIST := {s};
    while LIST ≠ ∅ do 
    begin
        remove an element i from LIST;
        for each arc (i,j) ∈ A(i) do
        if d(j) > d(i) + cij then
        begin
            d(j) := d(i) + cij;
            pred(j) := i;
            if j ∉ LIST then add node j to LIST;
        end;
    end;
end;

algorithm FIFO Implementation of MLC
begin
    d(s) := 0 and pred(s) := 0;
    d(j) := ∞ for each node j ∈ N-{s};
    LIST := {s};
    while LIST ≠ ∅ do 
    begin
        remove the first element i from LIST;
        for each arc (i,j) ∈ A(i) do
        if d(j) > d(i) + cij then
        begin
            d(j) := d(i) + cij;
            pred(j) := i;
            if j ∉ LIST then add node j to the end of LIST;
        end;
    end;
end;


algorithm Deque Implementation of MLC
begin
    d(s) := 0 and pred(s) := 0;
    d(j) := ∞ for each node j ∈ N-{s};
    LIST := {s};
    while LIST ≠ ∅ do 
    begin
        remove the first element i from LIST;
        for each arc (i,j) ∈ A(i) do
        if d(j) > d(i) + cij then
        begin
            d(j) := d(i) + cij;
            pred(j) := i;
            if j ∉ LIST then
                if j is not in LIST earlier then add node j to the end of LIST;
                else add node j to the front of LIST;
        end;
    end;
end;


algorithm Minimum Distance Label Implementation of MLC
begin
    d(s) := 0 and pred(s) := 0;
    d(j) := ∞ for each node j ∈ N-{s};
    LIST := {s};
    while LIST ≠ ∅ do
    begin
        remove i with the minimum distance label from LIST;
        for each arc (i,j) ∈ A(i) do
        if d(j) > d(i) + cij then
        begin
            d(j) := d(i) + cij;
            pred(j) := i;
            if j ∉ LIST then add node j to the end of LIST;
        end;
    end;
end;

algorithm DIJKSTRA;
begin
    P : = (s) ; T : = N - {s);
    d(s) : = 0 and pred(s) : = 0;
    d(j) : = Csj and pred(j) : = s if (s,j) € A, and d(j) ; = > otherwise;
    while P= N do
    begin
        (node selection) let i € T be a node for which d(i) = min {d(j) : j € T);
        P : = Pu(i); T: = T - (i);
        (distance update) for each (i,j) € A(i) do
        if d(j) > d(i) + c ¡¡ then d(j) : = d(i) + c ¡¡ and pred(j) : = i;
    end;
end;