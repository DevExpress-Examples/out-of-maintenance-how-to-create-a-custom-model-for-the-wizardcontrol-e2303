<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128639250/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2303)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [frmMain.cs](./CS/frmMain.cs) (VB: [frmMain.vb](./VB/frmMain.vb))
* [MyBackButtonViewInfo.cs](./CS/MyWizardControl/MyNextButton/MyBackButtonViewInfo.cs) (VB: [MyBackButtonViewInfo.vb](./VB/MyWizardControl/MyNextButton/MyBackButtonViewInfo.vb))
* [MyButtonPainter.cs](./CS/MyWizardControl/MyNextButton/MyButtonPainter.cs) (VB: [MyButtonPainter.vb](./VB/MyWizardControl/MyNextButton/MyButtonPainter.vb))
* [MyNextButton.cs](./CS/MyWizardControl/MyNextButton/MyNextButton.cs) (VB: [MyNextButton.vb](./VB/MyWizardControl/MyNextButton/MyNextButton.vb))
* [MyWizardAeroModel.cs](./CS/MyWizardControl/MyWizardAeroModel.cs) (VB: [MyWizardAeroModel.vb](./VB/MyWizardControl/MyWizardAeroModel.vb))
* [MyWizardControl.cs](./CS/MyWizardControl/MyWizardControl.cs) (VB: [MyWizardControl.vb](./VB/MyWizardControl/MyWizardControl.vb))
* [MyWizardViewInfo.cs](./CS/MyWizardControl/MyWizardViewInfo.cs) (VB: [MyWizardViewInfo.vb](./VB/MyWizardControl/MyWizardViewInfo.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to create a custom model for the WizardControl


<p>Currently the WizardControl provides two <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraWizardWizardControl_WizardStyletopic">WizardStyles</a> which are created according to MS standards:<br />
- <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraWizardWizardStyleEnumtopic">Wizard97</a> <br />
- <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraWizardWizardStyleEnumtopic">WizardAero</a></p><p>If you want to create a custom style for the WizardControl, you need to create a descendant of one of these models and customize it as your needs dictate. This example shows how to add an additional button to the WizardAero model. </p><p>Main steps:<br />
1. Create a custom button, which takes the "BackButton" image from an applied skin, and draw it mirrored. This will allow you to have two buttons : Previous page and Next page.<br />
2. As soon as we create a custom button, we should add it to a custom WizardControl and subscribe to required events to reflect the WizardControl's state. <br />
3. Finally, override WizardAeroModel's UpdateButtonsLocation method to specify the custom button's location.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E1880">How to add a navigation bar to the WizardControl when its style is WizardAero</a></p>

<br/>


