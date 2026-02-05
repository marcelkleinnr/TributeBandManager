# Copilot Instructions

## General Guidelines
- First general instruction
- Second general instruction

## Blazor Component Development
- When diagnosing Blazor component issues, prefer Blazor-specific fixes:
  - Use instance component state (non-static fields).
  - Initialize data in lifecycle methods (OnInitialized/OnParametersSet).
  - Avoid static fields for UI state.
  - Capture foreach loop variables into locals to avoid closure issues.