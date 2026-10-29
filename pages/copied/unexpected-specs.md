---
layout: center
---

# Intent-Extraction durch die KI

---
layout: default
---

## Basic Webhook Functionality - spec.md

```md
## 6. Validation and Security
- URL rules
  - HTTPS required.
  - Development exception: allow `localhost` (and `http://localhost`) in dev environments only.
  - Block private/internal IP ranges and special ranges:
    - RFC1918: 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16
    - Loopback: 127.0.0.0/8, ::1
    - Link-local: 169.254.0.0/16, fe80::/10
    - Unique-local: fc00::/7
    - Multicast: 224.0.0.0/4, ff00::/8
  - Max URL length: 2,048 characters.
  - Enforce TLS certificate verification for HTTPS.
- Request size limits
  - Payload: ≤ 256KB
  - Headers (combined): ≤ 16KB
- Response header redaction (case-insensitive keys)
  - `Authorization`, `Proxy-Authorization`, `Cookie`, `Set-Cookie`, `X-Api-Key`, `X-Auth-Token`, `X-Amz-*`
```