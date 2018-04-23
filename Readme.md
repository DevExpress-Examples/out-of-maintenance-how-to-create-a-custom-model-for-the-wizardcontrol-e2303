# How to create a custom model for the WizardControl


<p>Currently the WizardControl provides two <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraWizardWizardControl_WizardStyletopic">WizardStyles</a> which are created according to MS standards:<br />
- <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraWizardWizardStyleEnumtopic">Wizard97</a> <br />
- <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraWizardWizardStyleEnumtopic">WizardAero</a></p><p>If you want to create a custom style for the WizardControl, you need to create a descendant of one of these models and customize it as your needs dictate. This example shows how to add an additional button to the WizardAero model. </p><p>Main steps:<br />
1. Create a custom button, which takes the "BackButton" image from an applied skin, and draw it mirrored. This will allow you to have two buttons : Previous page and Next page.<br />
2. As soon as we create a custom button, we should add it to a custom WizardControl and subscribe to required events to reflect the WizardControl's state. <br />
3. Finally, override WizardAeroModel's UpdateButtonsLocation method to specify the custom button's location.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E1880">How to add a navigation bar to the WizardControl when its style is WizardAero</a></p>

<br/>


