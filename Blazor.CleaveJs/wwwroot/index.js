export function setInput(id, settings) {
    new Cleave(id, settings);
}

export function setInputWithCallback(id, settings, dotObj) {
    new Cleave(id, {
        ...settings,
        onCreditCardTypeChanged: (type) => {
            const result = type === "unknown" ? null : type;
            dotObj.invokeMethodAsync("CreditCardTypeChangedHandler", result);
        }
    })
}
