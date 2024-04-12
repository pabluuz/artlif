function displayRules()
{
$receivedContent = ""; 
commandToServer('RequestRules');
}

function clientCmdDisplayRules(%content)
{
$receivedContent = $receivedContent @ %content;
}


function clientCmdEndRulesTransmission()
{


    %gui = new GuiControl(RulesWindow) 
	{
		position = "0 0";
		extent = "1024 720";
		profile = "GuiOverlayProfile";
		visible = "1";
		active = "1";
		isContainer = "1";
		canSave = "1";
		canSaveDynamicFields = "1";
		
		new GuiWindowCtrl(RulesWindowDlg)
		{
			text = GetMessageIDText(5207); // Server Rules
			resizeWidth = "0";
			resizeHeight = "0";
			canMove = "1";
			canClose = "1";
			canMaximize = "0";
			canMinimize = "0";
			canHideOnFreelook = "0";
			canLock = "0";
			canSetup = "0";
			locked = "0";
			position = "0 20";
			extent = "1000 680";
			profile = "GuiAutoCursorWindowProfile";
			visible = "1";
			active = "1";
			isContainer = "1";
			closeCommand ="closeRulesWindow();";
			accelerator = "escape";
			horizSizing = "center";
			vertSizing = "height";

			
			new GuiContainer()
			{
				docking = Client;
				extent = "500 500";
				canSaveDynamicFields = "0";
				Enabled = "1";
				Profile = "GuiAtlas3TiledImageProfile";
				canSave = "1";
				Visible = "1";
				canHit = "true";
				BackgroundIndex = LearningWindowBackground;

				new GuiScrollCtrl()
				{
					position = "4 40";
					extent = "500 420";
					hScrollBar = "alwaysOff";
					vScrollBar = "alwaysOn";
					profile = "GuiEagleScrollBarProfile";
					constantThumbHeight = true;
					childMargin = "20 0";
					trackOffset = 12;
					lockHorizScroll = true;
					arrowSadowSize = -17;
					addContentWidth = 29; 
					isContainer = "1";
					horizSizing = "width";
					vertSizing = "height";
					
					new GuiStackControl()
					{
						position = "0 0";
						extent = "450 100";
						profile = "GuiDefaultProfile";
						stackingType = Vertical;
						padding = 2;
						dynamicSize = "1";
						dynamicNonStackExtent = "0";
						changeChildPosition = "1";
						changeChildSizeToFit = "1";
						horizSizing = "width";
						LeftIndent = 25;

						new GuiMLTextCtrl(RulesWindowsText)
						{
							text = $receivedContent;
							position = "0 0";
							extent = "0 0";
							profile = "SplitStackItemTextNameProfile";
							canHit = "1"; 
							visible = "1";
							lineSpacing = "0";
							bottomOffset = "0";
							useURLMouseCursor = "1";
						};
					};
				};
			};
		};
	};

	Canvas.pushDialog(%gui);

}

function closeRulesWindow()
{
	if (isObject(RulesWindow))
	{
		Canvas.popDialog(RulesWindow);
		RulesWindow.safeDeleteObject();
	}
}

