---
layout: default
---

## Basic Webhook Functionality - spec.md

```markdown
# Specification: Schedule Recurring Tasks
## Goal
Extend the scheduling system to support recurring tasks using a single-entity model. Each recurring task maintains its
    own state and automatically schedules its next occurrence after successful execution or failure, optimized for
    carbon intensity.
## User Stories
- **As a developer**, I want to schedule a recurring webhook (e.g., "Daily at 02:00") and have the system find the
    optimal execution time within a window (e.g., "between 02:00 and 06:00") for each day.
- **As a system operator**, I want to see the execution history of a recurring task, with each occurrence clearly
    indexed to correlate attempts.
- **As a user**, I want to be able to pause a recurring task to temporarily stop it from executing.
## Requirements
### 1. Recurrence Rule
- Support common recurrence patterns (Daily, Weekly, Monthly) via CRON expressions.
- The `Schedule` entity will include a `RecurrenceRule` string.
- Value `"Never"` indicates a one-time schedule (backward compatibility).
- Default behavior: Schedules are recurring if a valid CRON expression is provided.
- **CRON Alignment**: If the user defines a custom CRON expression and it doesn't align with the provided
  `EarliestStart`, the scheduler must find the first valid occurrence according to the CRON expression that
  is equal to or later than the specified `EarliestStart`.
```