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


# Examples

```html
<CleaveWrapper CreditCard="true" OnCreditCardTypeChanged="(type) => _type = type">
    <input id="@context" />
</CleaveWrapper>

<CleaveWrapper Phone="true" PhoneRegionCode="AC">
    <input id="@context" />
</CleaveWrapper>

<CleaveWrapper Date="true" Delimiter="-" DatePattern="@(["Y", "m", "d"])">
    <input id="@context" />
</CleaveWrapper>

<CleaveWrapper Date="true" DatePattern="@(["m", "y"])">
    <input id="@context" />
</CleaveWrapper>

<CleaveWrapper Time="true" TimePattern="@(["h", "m", "s"])">
    <input id="@context" />
</CleaveWrapper>

<CleaveWrapper Time="true" TimePattern="@(["h", "m"])">
    <input id="@context" />
</CleaveWrapper>

<CleaveWrapper Numeral="true" NumeralThousandsGroupStyle="NumeralThousandsGroupStyleType.Thousand">
    <input id="@context" />
</CleaveWrapper>

<CleaveWrapper Numeral="true" NumeralThousandsGroupStyle="NumeralThousandsGroupStyleType.Lakh">
    <input id="@context" />
</CleaveWrapper>
    
<CleaveWrapper Numeral="true" NumeralThousandsGroupStyle="NumeralThousandsGroupStyleType.Wan">
    <input id="@context" />
</CleaveWrapper>

<CleaveWrapper Blocks="[4,4,4,4]" Uppercase="true">
    <input id="@context" />
</CleaveWrapper>

<CleaveWrapper Blocks="[4,4,4]" Uppercase="true" Delimiter="!">
    <input id="@context" />
</CleaveWrapper>

<CleaveWrapper Blocks="[4,4,4]" Uppercase="true" Delimiters="@([".", "-", "."])">
    <input id="@context" />
</CleaveWrapper>

<CleaveWrapper Prefix="$" Numeral="true">
    <input id="@context" />
</CleaveWrapper>

<CleaveWrapper NumeralDecimalMark="^" Numeral="true">
    <input id="@context" />
</CleaveWrapper>
```