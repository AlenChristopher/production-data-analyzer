# 🏭 Production Data Analyzer

A data-driven production analysis tool built using C# and Power BI to identify bottlenecks and performance insights.

---

##  What This Project Does

This tool analyzes production data from a CSV file and identifies:

* Total processing time per station
* Failure count per station
* Bottleneck station 

---

## 🛠 Tech Stack

* C# (.NET Console Application)
* CSV / Excel Data
* Power BI (for visualization)

---

##  Example Output

```bash
---- Production Analysis ----
Station1: Total Time = 6, Failures = 0
Station2: Total Time = 11, Failures = 2
Station3: Total Time = 12, Failures = 1

 Bottleneck: Station3
```

---

##  Project Structure

```
analyzer/   → Core analysis logic
data/       → Input production data
results/    → Output files
dashboard/  → Power BI dashboard
```

---

##  Future Improvements

* Add Excel (.xlsx) support
* Export results automatically
* Integrate real-time data
* Add predictive analytics

---

##  Author

Alen Christopher
Master’s in Production Engineering @ Chalmers
