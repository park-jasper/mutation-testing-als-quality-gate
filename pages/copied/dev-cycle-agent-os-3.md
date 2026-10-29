---
layout: default
---

<style scoped>
div .mermaid {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 80%
}
</style>

# Was man mittlerweile macht (AgentOS v3)

```mermaid
stateDiagram-v2
    direction LR
    [*] --> PlanMode

    state "Planning" as PlanMode {
        direction LR
        state "/plan" as PlanCommand
        
        state "Specification" as SpecWrapper {
            state "/write-spec" as WriteSpec
            state "spec.md" as Spec
            WriteSpec --> Spec
            Spec --> WriteSpec : Iterate
        }

        PlanCommand --> SpecWrapper
    }

    PlanMode --> BuildMode

    state "Implementation" as BuildMode {
        direction LR
        state "/build" as BuildCommand

        state "Code" as ImplementWrapper {
            state "&quot;implement specification&quot;" as ImplementCode
            state "Code.cs" as Code
            ImplementCode --> Code
            Code --> ImplementCode : Iterate
        }

        BuildCommand --> ImplementWrapper
    }

    state "Review/Test" as Review

    BuildMode    --> Review
    Review --> [*]
```

<!-- Notes: Hi I am a note -->