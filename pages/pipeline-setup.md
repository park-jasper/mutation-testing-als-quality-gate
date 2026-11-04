---
layout: default
---

# In der Pipeline ausführen (GitHub Workflows)

<<< @/.github/workflows/build-and-test-basic.yml#Install yaml {lines:true}

```yaml
# restore, build, test
```

<<< @/.github/workflows/build-and-test-basic.yml#Run yaml {lines:true}

---
layout: default
---

```
Run /home/runner/work/mutation-testing-als-quality-gate/mutation-testing-als-quality-gate/tools/dotnet-stryker
  --config-file stryker-config-test-suite-3.json --threshold-high 90 --threshold-low 80 --break-at 70

[15:22:29 INF] Analyzing 1 test project(s).
[15:22:32 INF] Picking net10.0 for project /home/runner/work/mutation-testing-als-quality-gate/mutation-testing-als-quality-gate/demo/MutationTestingBasics/UserCode/UserCode.csproj. 
[15:22:32 INF] Found project /home/runner/work/mutation-testing-als-quality-gate/mutation-testing-als-quality-gate/demo/MutationTestingBasics/UserCode/UserCode.csproj to mutate.
[15:22:32 INF] Building test project /home/runner/work/mutation-testing-als-quality-gate/mutation-testing-als-quality-gate/demo/MutationTestingBasics/TestCode/TestCode.csproj (1/1)
[15:22:32 INF] Building project TestCode.csproj using dotnet build TestCode.csproj -c Debug --property:Platform=AnyCPU (directory /home/runner/work/mutation-testing-als-quality-gate/mutation-testing-als-quality-gate/demo/MutationTestingBasics/TestCode.)
[15:22:39 INF] Number of tests found: 6 for project /home/runner/work/mutation-testing-als-quality-gate/mutation-testing-als-quality-gate/demo/MutationTestingBasics/UserCode/UserCode.csproj. Initial test run started.
[15:22:45 INF] 24 mutants created
[15:22:45 INF] Capture mutant coverage using 'CoverageBasedTest' mode.
[15:22:46 INF] 4     mutants got status Ignored.      Reason: Removed by block already covered filter
[15:22:46 INF] 4     total mutants are skipped for the above mentioned reasons
[15:22:46 INF] 20    total mutants will be tested

Killed:   18
Survived:  1
Timeout:   1
Errors:   0

[15:23:11 INF] Time Elapsed 00:00:41.4935786
[15:23:11 INF] The final mutation score is 95.00 %
```

---
layout: default
---

# Pipeline mit Baseline (Stryker Dashboard)

<<< @/.github/workflows/build-and-test-dashboard.yml#Install yaml {lines:true}

```yaml
# restore, build, test
```

<<< @/.github/workflows/build-and-test-dashboard.yml#Run yaml {lines:true}

---
layout: default
---

# Dashboard

[https://dashboard.stryker-mutator.io/reports/github.com/park-jasper/mutation-testing-als-quality-gate/main#mutant](https://dashboard.stryker-mutator.io/reports/github.com/park-jasper/mutation-testing-als-quality-gate/main#mutant)