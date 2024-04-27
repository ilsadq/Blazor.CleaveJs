# Blazor Cleave.js

Cleave.js has a simple purpose: to help you format input text content automatically.

[CleaveJs demo site](https://nosir.github.io/cleave.js/)

# Features

- Credit card number formatting
- Phone number formatting (i18n js lib separated for each country to reduce size)
- Date formatting
- Numeral formatting
- Custom delimiter, prefix and blocks pattern

# Why

The idea is to provide an easy way to increase input field readability by formatting your typed data. By using this library, you won't need to write any mind-blowing regular expressions or mask patterns to format input text.

However, this isn't meant to replace any validation or mask library, you should still sanitize and validate your data in backend.

# Installation

`dotnet add package Blazor.CleaveJs`

`<script src="_content/Blazor.CleaveJs/cleave.js"></script>`

`builder.Services.AddScoped<CleaveJsProvider>();`

*Optional

`<script src="_content/Blazor.CleaveJs/addons/cleave-phone.ac.js"></script>`
