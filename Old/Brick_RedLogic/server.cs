exec("base/redscripts/server/boost/seval.cs");

datablock fxDTSBrickData(ALU8Bit4OpBrickData:Powerbrick1x1Data){
	category="LogicBricks";
	subCategory="Processing";
	uiName="8Bit 4Operator ALU";
	iconName="base/client/ui/brickIcons/4x16f";
	brickFile="base/data/bricks/flats/4x16F.blb";
	alwaysShowWireFrame=false;
	IsLogicBrick=1;
	IsGate=1;
	GateName="8Bit 4Operator ALU";
	TipInfo="A Turing-Complete Processor that can perform AND, OR, XOR, NOR, Bitshift (L, R), Add, Subtract, Multiply, and Divide"@
	"<br>Produces an output of 16 bits and a negation output.<br>Made by Redoctober2009 (12878)";
	
	ISINSTANT=0;
	
	numPE=17;
	
	PEName[0]="Out0";
	PEPos[0]="3.75 0.75 0.0";
	PEScale[0]="0.5 0.5 0.16666";
	PEStart[0]=0;
	
	PEName[1]="Out1";
	PEPos[1]="3.25 0.75 0.0";
	PEScale[1]="0.5 0.5 0.16666";
	
	PEName[2]="Out2";
	PEPos[2]="2.75 0.75 0.0";
	PEScale[2]="0.5 0.5 0.16666";
	
	PEName[3]="Out3";
	PEPos[3]="2.25 0.75 0.0";
	PEScale[3]="0.5 0.5 0.16666";
	
	PEName[4]="Out4";
	PEPos[4]="1.75 0.75 0.0";
	PEScale[4]="0.5 0.5 0.16666";
	
	PEName[5]="Out5";
	PEPos[5]="1.25 0.75 0.0";
	PEScale[5]="0.5 0.5 0.16666";
	
	PEName[6]="Out6";
	PEPos[6]="0.75 0.75 0.0";
	PEScale[6]="0.5 0.5 0.16666";
	
	PEName[7]="Out7";
	PEPos[7]="0.25 0.75 0.0";
	PEScale[7]="0.5 0.5 0.16666";
	
	
	PEName[8]="Out8";
	PEPos[8]="-0.25 0.75 0.0";
	PEScale[8]="0.5 0.5 0.16666";
	
	PEName[9]="Out9";
	PEPos[9]="-0.75 0.75 0.0";
	PEScale[9]="0.5 0.5 0.16666";
	
	PEName[10]="Out10";
	PEPos[10]="-1.25 0.75 0.0";
	PEScale[10]="0.5 0.5 0.16666";
	
	PEName[11]="Out11";
	PEPos[11]="-1.75 0.75 0.0";
	PEScale[11]="0.5 0.5 0.16666";
	
	PEName[12]="Out12";
	PEPos[12]="-2.25 0.75 0.0";
	PEScale[12]="0.5 0.5 0.16666";
	
	PEName[13]="Out13";
	PEPos[13]="-2.75 0.75 0.0";
	PEScale[13]="0.5 0.5 0.16666";
	
	PEName[14]="Out14";
	PEPos[14]="-3.25 0.75 0.0";
	PEScale[14]="0.5 0.5 0.16666";
	
	PEName[15]="Out15";
	PEPos[15]="-3.75 0.75 0.0";
	PEScale[15]="0.5 0.5 0.16666";
	
	
	PEName[16]="OutSign";
	PEPos[16]="-3.75 0.25 0.0";
	PEScale[16]="0.5 0.5 0.16666";
	
	
	numIE=23;
	
	IEName[0]="In0_0";
	IEPos[0]="3.75 -0.75 0.0";
	IEScale[0]="0.5 0.5 0.16666";
	
	IEName[1]="In0_1";
	IEPos[1]="3.25 -0.75 0.0";
	IEScale[1]="0.5 0.5 0.16666";
	
	IEName[2]="In0_2";
	IEPos[2]="2.75 -0.75 0.0";
	IEScale[2]="0.5 0.5 0.16666";
	
	IEName[3]="In0_3";
	IEPos[3]="2.25 -0.75 0.0";
	IEScale[3]="0.5 0.5 0.16666";
	
	IEName[4]="In0_4";
	IEPos[4]="1.75 -0.75 0.0";
	IEScale[4]="0.5 0.5 0.16666";
	
	IEName[5]="In0_5";
	IEPos[5]="1.25 -0.75 0.0";
	IEScale[5]="0.5 0.5 0.16666";
	
	IEName[6]="In0_6";
	IEPos[6]="0.75 -0.75 0.0";
	IEScale[6]="0.5 0.5 0.16666";

	IEName[7]="In0_7";
	IEPos[7]="0.25 -0.75 0.0";
	IEScale[7]="0.5 0.5 0.16666";
	
	
	IEName[8]="In1_0";
	IEPos[8]="-0.25 -0.75 0.0";
	IEScale[8]="0.5 0.5 0.16666";
	
	IEName[9]="In1_1";
	IEPos[9]="-0.75 -0.75 0.0";
	IEScale[9]="0.5 0.5 0.16666";
	
	IEName[10]="In1_2";
	IEPos[10]="-1.25 -0.75 0.0";
	IEScale[10]="0.5 0.5 0.16666";
	
	IEName[11]="In1_3";
	IEPos[11]="-1.75 -0.75 0.0";
	IEScale[11]="0.5 0.5 0.16666";
	
	IEName[12]="In1_4";
	IEPos[12]="-2.25 -0.75 0.0";
	IEScale[12]="0.5 0.5 0.16666";
	
	IEName[13]="In1_5";
	IEPos[13]="-2.75 -0.75 0.0";
	IEScale[13]="0.5 0.5 0.16666";
	
	IEName[14]="In1_6";
	IEPos[14]="-3.25 -0.75 0.0";
	IEScale[14]="0.5 0.5 0.16666";

	IEName[15]="In1_7";
	IEPos[15]="-3.75 -0.75 0.0";
	IEScale[15]="0.5 0.5 0.16666";
	
	IEName[16]="Operator0";
	IEPos[16]="3.75 -0.25 0.0";
	IEScale[16]="0.5 0.5 0.16666";
	
	IEName[17]="Operator1";
	IEPos[17]="3.75 0.25 0.0";
	IEScale[17]="0.5 0.5 0.16666";
	
	IEName[18]="Operator2";
	IEPos[18]="3.25 -0.25 0.0";
	IEScale[18]="0.5 0.5 0.16666";
	
	IEName[19]="Operator3";
	IEPos[19]="3.25 0.25 0.0";
	IEScale[19]="0.5 0.5 0.16666";
	
	IEName[20]="Clock";
	IEPos[20]="-3.75 -0.25 0.0";
	IEScale[20]="0.5 0.5 0.16666";
	
	IEName[21]="In0_Sign";
	IEPos[21]="0.25 -0.25 0.0";
	IEScale[21]="0.5 0.5 0.16666";
	
	IEName[22]="In1_Sign";
	IEPos[22]="-0.25 -0.25 0.0";
	IEScale[22]="0.5 0.5 0.16666";
};
datablock fxDTSBrickData(RAM8Bit8AddBitBrickData:Powerbrick1x1Data){
	category="LogicBricks";
	subCategory="Memory";
	uiName="256 8AddBit Synchronous RAM";
	iconName="base/client/ui/brickIcons/4x16f";
	brickFile="base/data/bricks/flats/4x16F.blb";
	alwaysShowWireFrame=false;
	IsLogicBrick=1;
	IsGate=1;
	GateName="8Bit 8AddressBit Synchronous RAM";
	TipInfo="Stores 256 8-bit words with read and write access.<br>Made by Redoctober2009 (12878)";

	ISINSTANT=0;

	numPE=8;

	PEName[0]="Out0";
	PEPos[0]="-0.25 0.75 0.0";
	PEScale[0]="0.5 0.5 0.16666";
	PEStart[0]=0;

	PEName[1]="Out1";
	PEPos[1]="-0.75 0.75 0.0";
	PEScale[1]="0.5 0.5 0.16666";

	PEName[2]="Out2";
	PEPos[2]="-1.25 0.75 0.0";
	PEScale[2]="0.5 0.5 0.16666";

	PEName[3]="Out3";
	PEPos[3]="-1.75 0.75 0.0";
	PEScale[3]="0.5 0.5 0.16666";

	PEName[4]="Out4";
	PEPos[4]="-2.25 0.75 0.0";
	PEScale[4]="0.5 0.5 0.16666";

	PEName[5]="Out5";
	PEPos[5]="-2.75 0.75 0.0";
	PEScale[5]="0.5 0.5 0.16666";

	PEName[6]="Out6";
	PEPos[6]="-3.25 0.75 0.0";
	PEScale[6]="0.5 0.5 0.16666";

	PEName[7]="Out7";
	PEPos[7]="-3.75 0.75 0.0";
	PEScale[7]="0.5 0.5 0.16666";

	numIE=19;

	IEName[0]="In0";
	IEPos[0]="-0.25 -0.75 0.0";
	IEScale[0]="0.5 0.5 0.16666";

	IEName[1]="In1";
	IEPos[1]="-0.75 -0.75 0.0";
	IEScale[1]="0.5 0.5 0.16666";

	IEName[2]="In2";
	IEPos[2]="-1.25 -0.75 0.0";
	IEScale[2]="0.5 0.5 0.16666";

	IEName[3]="In3";
	IEPos[3]="-1.75 -0.75 0.0";
	IEScale[3]="0.5 0.5 0.16666";

	IEName[4]="In4";
	IEPos[4]="-2.25 -0.75 0.0";
	IEScale[4]="0.5 0.5 0.16666";

	IEName[5]="In5";
	IEPos[5]="-2.75 -0.75 0.0";
	IEScale[5]="0.5 0.5 0.16666";

	IEName[6]="In6";
	IEPos[6]="-3.25 -0.75 0.0";
	IEScale[6]="0.5 0.5 0.16666";

	IEName[7]="In7";
	IEPos[7]="-3.75 -0.75 0.0";
	IEScale[7]="0.5 0.5 0.16666";


	IEName[8]="Write Enable";
	IEPos[8]="2.25 0.75 0.0";
	IEScale[8]="0.5 0.5 0.16666";

	IEName[9]="Read Enable";
	IEPos[9]="2.75 0.75 0.0";
	IEScale[9]="0.5 0.5 0.16666";


	IEName[10]="Clock";
	IEPos[10]="3.75 0.75 0.0";
	IEScale[10]="0.5 0.5 0.16666";


	IEName[11]="Address0";
	IEPos[11]="3.75 -0.75 0.0";
	IEScale[11]="0.5 0.5 0.16666";

	IEName[12]="Address1";
	IEPos[12]="3.25 -0.75 0.0";
	IEScale[12]="0.5 0.5 0.16666";

	IEName[13]="Address2";
	IEPos[13]="2.75 -0.75 0.0";
	IEScale[13]="0.5 0.5 0.16666";

	IEName[14]="Address3";
	IEPos[14]="2.25 -0.75 0.0";
	IEScale[14]="0.5 0.5 0.16666";

	IEName[15]="Address4";
	IEPos[15]="1.75 -0.75 0.0";
	IEScale[15]="0.5 0.5 0.16666";

	IEName[16]="Address5";
	IEPos[16]="1.25 -0.75 0.0";
	IEScale[16]="0.5 0.5 0.16666";

	IEName[17]="Address6";
	IEPos[17]="0.75 -0.75 0.0";
	IEScale[17]="0.5 0.5 0.16666";

	IEName[18]="Address7";
	IEPos[18]="0.25 -0.75 0.0";
	IEScale[18]="0.5 0.5 0.16666";
};
datablock fxDTSBrickData(Latch4BitBrickData:Powerbrick1x1Data){
	category="LogicBricks";
	subCategory="Special";
	uiName="4Bit DLatch";
	iconName="base/client/ui/brickIcons/4x4f";
	brickFile="base/data/bricks/flats/4x4F.blb";
	alwaysShowWireFrame=false;
	IsLogicBrick=1;
	IsGate=1;
	GateName="4Bit DLatch";
	TipInfo="A 4Bit DLatch<br>Made by Redoctober2009 (12878)";

	ISINSTANT=0;

	numPE=4;

	PEName[0]="Out0";
	PEPos[0]="0.75 0.75 0.0";
	PEScale[0]="0.5 0.5 0.16666";
	PEStart[0]=0;

	PEName[1]="Out1";
	PEPos[1]="0.25 0.75 0.0";
	PEScale[1]="0.5 0.5 0.16666";

	PEName[2]="Out2";
	PEPos[2]="-0.25 0.75 0.0";
	PEScale[2]="0.5 0.5 0.16666";

	PEName[3]="Out3";
	PEPos[3]="-0.75 0.75 0.0";
	PEScale[3]="0.5 0.5 0.16666";

	numIE=6;

	IEName[0]="In0";
	IEPos[0]="0.75 -0.75 0.0";
	IEScale[0]="0.5 0.5 0.16666";

	IEName[1]="In1";
	IEPos[1]="0.25 -0.75 0.0";
	IEScale[1]="0.5 0.5 0.16666";

	IEName[2]="In2";
	IEPos[2]="-0.25 -0.75 0.0";
	IEScale[2]="0.5 0.5 0.16666";

	IEName[3]="In3";
	IEPos[3]="-0.75 -0.75 0.0";
	IEScale[3]="0.5 0.5 0.16666";


	IEName[4]="Clock";
	IEPos[4]="0.75 -0.25 0.0";
	IEScale[4]="0.5 0.5 0.16666";

	IEName[5]="Reset";
	IEPos[5]="0.75 0.25 0.0";
	IEScale[5]="0.5 0.5 0.16666";
};
datablock fxDTSBrickData(Latch8BitBrickData:Powerbrick1x1Data){
	category="LogicBricks";
	subCategory="Special";
	uiName="8Bit DLatch";
	iconName="base/client/ui/brickIcons/4x8f";
	brickFile="base/data/bricks/flats/4x8F.blb";
	alwaysShowWireFrame=false;
	IsLogicBrick=1;
	IsGate=1;
	GateName="8Bit DLatch";
	TipInfo="An 8Bit DLatch<br>Made by Redoctober2009 (12878)";

	ISINSTANT=0;

	numPE=8;

	PEName[0]="Out0";
	PEPos[0]="1.75 0.75 0.0";
	PEScale[0]="0.5 0.5 0.16666";
	PEStart[0]=0;

	PEName[1]="Out1";
	PEPos[1]="1.25 0.75 0.0";
	PEScale[1]="0.5 0.5 0.16666";

	PEName[2]="Out2";
	PEPos[2]="0.75 0.75 0.0";
	PEScale[2]="0.5 0.5 0.16666";

	PEName[3]="Out3";
	PEPos[3]="0.25 0.75 0.0";
	PEScale[3]="0.5 0.5 0.16666";

	PEName[4]="Out4";
	PEPos[4]="-0.25 0.75 0.0";
	PEScale[4]="0.5 0.5 0.16666";

	PEName[5]="Out5";
	PEPos[5]="-0.75 0.75 0.0";
	PEScale[5]="0.5 0.5 0.16666";

	PEName[6]="Out6";
	PEPos[6]="-1.25 0.75 0.0";
	PEScale[6]="0.5 0.5 0.16666";

	PEName[7]="Out7";
	PEPos[7]="-1.75 0.75 0.0";
	PEScale[7]="0.5 0.5 0.16666";

	numIE=10;

	IEName[0]="In0";
	IEPos[0]="1.75 -0.75 0.0";
	IEScale[0]="0.5 0.5 0.16666";

	IEName[1]="In1";
	IEPos[1]="1.25 -0.75 0.0";
	IEScale[1]="0.5 0.5 0.16666";

	IEName[2]="In2";
	IEPos[2]="0.75 -0.75 0.0";
	IEScale[2]="0.5 0.5 0.16666";

	IEName[3]="In3";
	IEPos[3]="0.25 -0.75 0.0";
	IEScale[3]="0.5 0.5 0.16666";

	IEName[4]="In4";
	IEPos[4]="-0.25 -0.75 0.0";
	IEScale[4]="0.5 0.5 0.16666";

	IEName[5]="In5";
	IEPos[5]="-0.75 -0.75 0.0";
	IEScale[5]="0.5 0.5 0.16666";

	IEName[6]="In6";
	IEPos[6]="-1.25 -0.75 0.0";
	IEScale[6]="0.5 0.5 0.16666";

	IEName[7]="In7";
	IEPos[7]="-1.75 -0.75 0.0";
	IEScale[7]="0.5 0.5 0.16666";


	IEName[8]="Clock";
	IEPos[8]="1.75 -0.25 0.0";
	IEScale[8]="0.5 0.5 0.16666";

	IEName[9]="Reset";
	IEPos[9]="1.75 0.25 0.0";
	IEScale[9]="0.5 0.5 0.16666";
};
datablock fxDTSBrickData(Delay4BitBrickData:Powerbrick1x1Data){
	category="LogicBricks";
	subCategory="Special";
	uiName="4Bit Delay Gate";
	iconName="base/client/ui/brickIcons/2x4f";
	brickFile="base/data/bricks/flats/2x4F.blb";
	alwaysShowWireFrame=false;
	IsLogicBrick=1;
	IsGate=1;
	GateName="4Bit Delay Gate";
	TipInfo="Delays the time it takes for a signal to pass through.<br>Takes 4 bits as input for timing in 16th-seconds.<br>Made by Redoctober2009 (12878)";

	ISINSTANT=0;

	numPE=1;

	PEName[0]="Output";
	PEPos[0]="0.75 0.25 0.0";
	PEScale[0]="0.5 0.5 0.16666";
	PEStart[0]=0;

	numIE=5;

	IEName[0]="Time0";
	IEPos[0]="-0.75 -0.25 0.0";
	IEScale[0]="0.5 0.5 0.16666";

	IEName[1]="Time1";
	IEPos[1]="-0.25 -0.25 0.0";
	IEScale[1]="0.5 0.5 0.16666";

	IEName[2]="Time2";
	IEPos[2]="0.25 -0.25 0.0";
	IEScale[2]="0.5 0.5 0.16666";

	IEName[3]="Time3";
	IEPos[3]="0.75 -0.25 0.0";
	IEScale[3]="0.5 0.5 0.16666";

	IEName[4]="Input";
	IEPos[4]="-0.75 0.25 0.0";
	IEScale[4]="0.5 0.5 0.16666";
};
datablock fxDTSBrickData(Any6BitBrickData:Powerbrick1x1Data){
	category="LogicBricks";
	subCategory="Special";
	uiName="6Bit AnyGate";
	iconName="base/client/ui/brickIcons/2x6f";
	brickFile="base/data/bricks/flats/2x6F.blb";
	alwaysShowWireFrame=false;
	IsLogicBrick=1;
	IsGate=1;
	GateName="6Bit Any-Gate";
	TipInfo="An Logic Gate with 4 inputs. Can be selected which gate operation to use by selecting the number that the inputs should add up to.<br>"@
	"Output can be negated by the negate input.<br>Made by Redoctober2009 (12878)";

	ISINSTANT=0;

	numPE=1;

	PEName[0]="Output";
	PEPos[0]="1.25 0.25 0.0";
	PEScale[0]="0.5 0.5 0.16666";
	PEStart[0]=0;

	numIE=10;

	IEName[0]="In0";
	IEPos[0]="-1.25 -0.25 0.0";
	IEScale[0]="0.5 0.5 0.16666";

	IEName[1]="In1";
	IEPos[1]="-0.75 -0.25 0.0";
	IEScale[1]="0.5 0.5 0.16666";

	IEName[2]="In2";
	IEPos[2]="-0.25 -0.25 0.0";
	IEScale[2]="0.5 0.5 0.16666";

	IEName[3]="In3";
	IEPos[3]="0.25 -0.25 0.0";
	IEScale[3]="0.5 0.5 0.16666";

	IEName[4]="In4";
	IEPos[4]="0.75 -0.25 0.0";
	IEScale[4]="0.5 0.5 0.16666";

	IEName[5]="In5";
	IEPos[5]="1.25 -0.25 0.0";
	IEScale[5]="0.5 0.5 0.16666";

	IEName[6]="Operator0";
	IEPos[6]="-1.25 0.25 0.0";
	IEScale[6]="0.5 0.5 0.16666";

	IEName[7]="Operator1";
	IEPos[7]="-0.75 0.25 0.0";
	IEScale[7]="0.5 0.5 0.16666";

	IEName[8]="Operator2";
	IEPos[8]="-0.25 0.25 0.0";
	IEScale[8]="0.5 0.5 0.16666";

	IEName[9]="OperatorNegate";
	IEPos[9]="0.25 0.25 0.0";
	IEScale[9]="0.5 0.5 0.16666";
};
datablock fxDTSBrickData(PulseFormerBrickData:Powerbrick1x1Data){
	category="LogicBricks";
	subCategory="Gates";
	uiName="Pulse Former";
	iconName="base/client/ui/brickIcons/1x2f";
	brickFile="base/data/bricks/flats/1x2F.blb";
	alwaysShowWireFrame=false;
	IsLogicBrick=1;
	IsGate=1;
	GateName="Pulse Former";
	TipInfo="Sends a 1/8-Second Pulse when its input is activated.<br>Made by Redoctober2009 (12878)";

	ISINSTANT=0;

	numPE=1;

	PEName[0]="Output";
	PEPos[0]="0.25 0.0 0.0";
	PEScale[0]="0.5 0.5 0.16666";
	PEStart[0]=0;

	numIE=1;

	IEName[0]="Input";
	IEPos[0]="-0.25 0.0 0.0";
	IEScale[0]="0.5 0.5 0.16666";
};
datablock fxDTSBrickData(PulseFilterBrickData:Powerbrick1x1Data){
	category="LogicBricks";
	subCategory="Gates";
	uiName="Pulse Filter";
	iconName="base/client/ui/brickIcons/1x2f";
	brickFile="base/data/bricks/flats/1x2F.blb";
	alwaysShowWireFrame=false;
	IsLogicBrick=1;
	IsGate=1;
	GateName="Pulse Filter";
	TipInfo="Filters out any pulses shorter than 1/8-second.<br>Made by Redoctober2009 (12878)";

	ISINSTANT=0;

	numPE=1;

	PEName[0]="Output";
	PEPos[0]="0.25 0.0 0.0";
	PEScale[0]="0.5 0.5 0.16666";
	PEStart[0]=0;

	numIE=1;

	IEName[0]="Input";
	IEPos[0]="-0.25 0.0 0.0";
	IEScale[0]="0.5 0.5 0.16666";
};
datablock fxDTSBrickData(Enable4BitBrickData:Powerbrick1x1Data){
	category="LogicBricks";
	subCategory="Special";
	uiName="4Bit Enabler";
	iconName="base/client/ui/brickIcons/4x4f";
	brickFile="base/data/bricks/flats/4x4F.blb";
	alwaysShowWireFrame=false;
	IsLogicBrick=1;
	IsGate=1;
	GateName="4Bit Enabler";
	TipInfo="Only allows current to pass through when Set is on<br>Made by Redoctober2009 (12878)";

	ISINSTANT=0;

	numPE=4;

	PEName[0]="Out0";
	PEPos[0]="0.75 0.75 0.0";
	PEScale[0]="0.5 0.5 0.16666";
	PEStart[0]=0;

	PEName[1]="Out1";
	PEPos[1]="0.25 0.75 0.0";
	PEScale[1]="0.5 0.5 0.16666";

	PEName[2]="Out2";
	PEPos[2]="-0.25 0.75 0.0";
	PEScale[2]="0.5 0.5 0.16666";

	PEName[3]="Out3";
	PEPos[3]="-0.75 0.75 0.0";
	PEScale[3]="0.5 0.5 0.16666";

	numIE=5;

	IEName[0]="In0";
	IEPos[0]="0.75 -0.75 0.0";
	IEScale[0]="0.5 0.5 0.16666";

	IEName[1]="In1";
	IEPos[1]="0.25 -0.75 0.0";
	IEScale[1]="0.5 0.5 0.16666";

	IEName[2]="In2";
	IEPos[2]="-0.25 -0.75 0.0";
	IEScale[2]="0.5 0.5 0.16666";

	IEName[3]="In3";
	IEPos[3]="-0.75 -0.75 0.0";
	IEScale[3]="0.5 0.5 0.16666";

	IEName[4]="Set";
	IEPos[4]="0.75 -0.25 0.0";
	IEScale[4]="0.5 0.5 0.16666";
};
datablock fxDTSBrickData(Enable8BitBrickData:Powerbrick1x1Data){
	category="LogicBricks";
	subCategory="Special";
	uiName="8Bit Enabler";
	iconName="base/client/ui/brickIcons/4x8f";
	brickFile="base/data/bricks/flats/4x8F.blb";
	alwaysShowWireFrame=false;
	IsLogicBrick=1;
	IsGate=1;
	GateName="8Bit Enabler";
	TipInfo="Only allows current to pass through when Set is on<br>Made by Redoctober2009 (12878)";

	ISINSTANT=0;

	numPE=8;

	PEName[0]="Out0";
	PEPos[0]="1.75 0.75 0.0";
	PEScale[0]="0.5 0.5 0.16666";
	PEStart[0]=0;

	PEName[1]="Out1";
	PEPos[1]="1.25 0.75 0.0";
	PEScale[1]="0.5 0.5 0.16666";

	PEName[2]="Out2";
	PEPos[2]="0.75 0.75 0.0";
	PEScale[2]="0.5 0.5 0.16666";

	PEName[3]="Out3";
	PEPos[3]="0.25 0.75 0.0";
	PEScale[3]="0.5 0.5 0.16666";

	PEName[4]="Out4";
	PEPos[4]="-0.25 0.75 0.0";
	PEScale[4]="0.5 0.5 0.16666";

	PEName[5]="Out5";
	PEPos[5]="-0.75 0.75 0.0";
	PEScale[5]="0.5 0.5 0.16666";

	PEName[6]="Out6";
	PEPos[6]="-1.25 0.75 0.0";
	PEScale[6]="0.5 0.5 0.16666";

	PEName[7]="Out7";
	PEPos[7]="-1.75 0.75 0.0";
	PEScale[7]="0.5 0.5 0.16666";

	numIE=9;

	IEName[0]="In0";
	IEPos[0]="1.75 -0.75 0.0";
	IEScale[0]="0.5 0.5 0.16666";

	IEName[1]="In1";
	IEPos[1]="1.25 -0.75 0.0";
	IEScale[1]="0.5 0.5 0.16666";

	IEName[2]="In2";
	IEPos[2]="0.75 -0.75 0.0";
	IEScale[2]="0.5 0.5 0.16666";

	IEName[3]="In3";
	IEPos[3]="0.25 -0.75 0.0";
	IEScale[3]="0.5 0.5 0.16666";

	IEName[4]="In4";
	IEPos[4]="-0.25 -0.75 0.0";
	IEScale[4]="0.5 0.5 0.16666";

	IEName[5]="In5";
	IEPos[5]="-0.75 -0.75 0.0";
	IEScale[5]="0.5 0.5 0.16666";

	IEName[6]="In6";
	IEPos[6]="-1.25 -0.75 0.0";
	IEScale[6]="0.5 0.5 0.16666";

	IEName[7]="In7";
	IEPos[7]="-1.75 -0.75 0.0";
	IEScale[7]="0.5 0.5 0.16666";


	IEName[8]="Set";
	IEPos[8]="1.75 -0.25 0.0";
	IEScale[8]="0.5 0.5 0.16666";
};
datablock fxDTSBrickData(SevSeg4BitBrickData:Powerbrick1x1Data){
	category="LogicBricks";
	subCategory="Special";
	uiName="4Bit-7Seg Converter";
	iconName="base/client/ui/brickIcons/4x4f";
	brickFile="base/data/bricks/flats/4x4F.blb";
	alwaysShowWireFrame=false;
	IsLogicBrick=1;
	IsGate=1;
	GateName="4Bit-7Seg Converter";
	TipInfo="Converts 4-bit binary into 7-segment display output<br>Made by Redoctober2009 (12878)";

	ISINSTANT=0;

	numPE=7;

	PEName[0]="OutA";
	PEPos[0]="0.75 0.75 0.0";
	PEScale[0]="0.5 0.5 0.16666";
	PEStart[0]=0;

	PEName[1]="OutB";
	PEPos[1]="0.25 0.75 0.0";
	PEScale[1]="0.5 0.5 0.16666";

	PEName[2]="OutC";
	PEPos[2]="-0.25 0.75 0.0";
	PEScale[2]="0.5 0.5 0.16666";

	PEName[3]="OutD";
	PEPos[3]="-0.75 0.75 0.0";
	PEScale[3]="0.5 0.5 0.16666";

	PEName[4]="OutE";
	PEPos[4]="0.75 0.25 0.0";
	PEScale[4]="0.5 0.5 0.16666";

	PEName[5]="OutF";
	PEPos[5]="0.25 0.25 0.0";
	PEScale[5]="0.5 0.5 0.16666";

	PEName[6]="OutG";
	PEPos[6]="-0.25 0.25 0.0";
	PEScale[6]="0.5 0.5 0.16666";

	numIE=4;

	IEName[0]="In0";
	IEPos[0]="0.75 -0.75 0.0";
	IEScale[0]="0.5 0.5 0.16666";

	IEName[1]="In1";
	IEPos[1]="0.25 -0.75 0.0";
	IEScale[1]="0.5 0.5 0.16666";

	IEName[2]="In2";
	IEPos[2]="-0.25 -0.75 0.0";
	IEScale[2]="0.5 0.5 0.16666";

	IEName[3]="In3";
	IEPos[3]="-0.75 -0.75 0.0";
	IEScale[3]="0.5 0.5 0.16666";
};
datablock fxDTSBrickData(JKLatchBrickData:Powerbrick1x1Data){
	category="LogicBricks";
	subCategory="Special";
	uiName="JKFlipFlop";
	iconName="base/client/ui/brickIcons/2x3f";
	brickFile="base/data/bricks/flats/2x3F.blb";
	alwaysShowWireFrame=false;
	IsLogicBrick=1;
	IsGate=1;
	GateName="JK-FlipFlop";
	TipInfo="A JK Latch<br>Made by Redoctober2009 (12878)";

	ISINSTANT=0;

	numPE=2;

	PEName[0]="Q";
	PEPos[0]="-0.5 0.25 0";
	PEScale[0]="0.5 0.5 0.16666";
	PEStart[0]=0;

	PEName[1]="!Q";
	PEPos[1]="0.5 0.25 0";
	PEScale[1]="0.5 0.5 0.16666";

	numIE=3;

	IEName[0]="J";
	IEPos[0]="0.5 -0.25 0";
	IEScale[0]="0.5 0.5 0.16666";
	IENOTRIG[0]=0;

	IEName[1]="K";
	IEPos[1]="-0.5 -0.25 0";
	IEScale[1]="0.5 0.5 0.16666";
	IENOTRIG[1]=0;

	IEName[2]="Clock";
	IEPos[2]="0.0 -0.25 0";
	IEScale[2]="0.5 0.5 0.16666";
};
datablock fxDTSBrickData(LinearDLatchBrickData:Powerbrick1x1Data){
	category="LogicBricks";
	subCategory="Special";
	uiName="LinearDLatch";
	iconName="base/client/ui/brickIcons/1x3f";
	brickFile="base/data/bricks/flats/1x3F.blb";
	alwaysShowWireFrame=false;
	IsLogicBrick=1;
	IsGate=1;
	GateName="Linear D-FlipFlop";
	TipInfo="Linear D-FlipFlop<br>Made by Redoctober2009 (12878)";

	ISINSTANT=0;

	numPE=1;

	PEName[0]="Out";
	PEPos[0]="-0.5 0 0";
	PEScale[0]="0.5 0.5 0.16666";
	PEStart[0]=0;

	numIE=2;

	IEName[0]="Clock";
	IEPos[0]="0 0 0";
	IEScale[0]="0.5 0.5 0.16666";

	IEName[1]="D";
	IEPos[1]="0.5 0 0";
	IEScale[1]="0.5 0.5 0.16666";
};
datablock fxDTSBrickData(Letter6BitBrickData:Powerbrick1x1Data){
	category="LogicBricks";
	subCategory="Special";
	uiName="6Bit-Letter Converter";
	iconName="base/client/ui/brickIcons/4x16f";
	brickFile="base/data/bricks/flats/4x16F.blb";
	alwaysShowWireFrame=false;
	IsLogicBrick=1;
	IsGate=1;
	GateName="6Bit-Letter Converter";
	TipInfo="Converts 6-bit binary into 3x5 display output<br>Made by Redoctober2009 (12878)";

	ISINSTANT=0;

	numPE=15;
	
	PEName[0]="Out00";
	PEPos[0]="-3.75 0.75 0.0";
	PEScale[0]="0.5 0.5 0.16666";
	PEStart[0]=0;
	
	PEName[1]="Out01";
	PEPos[1]="-3.25 0.75 0.0";
	PEScale[1]="0.5 0.5 0.16666";
	
	PEName[2]="Out02";
	PEPos[2]="-2.75 0.75 0.0";
	PEScale[2]="0.5 0.5 0.16666";
	
	PEName[3]="Out10";
	PEPos[3]="-2.25 0.75 0.0";
	PEScale[3]="0.5 0.5 0.16666";
	
	PEName[4]="Out11";
	PEPos[4]="-1.75 0.75 0.0";
	PEScale[4]="0.5 0.5 0.16666";
	
	PEName[5]="Out12";
	PEPos[5]="-1.25 0.75 0.0";
	PEScale[5]="0.5 0.5 0.16666";
	
	PEName[6]="Out20";
	PEPos[6]="-0.75 0.75 0.0";
	PEScale[6]="0.5 0.5 0.16666";
	
	PEName[7]="Out21";
	PEPos[7]="-0.25 0.75 0.0";
	PEScale[7]="0.5 0.5 0.16666";
	
	PEName[8]="Out22";
	PEPos[8]="0.25 0.75 0.0";
	PEScale[8]="0.5 0.5 0.16666";
	
	PEName[9]="Out30";
	PEPos[9]="0.75 0.75 0.0";
	PEScale[9]="0.5 0.5 0.16666";
	
	PEName[10]="Out31";
	PEPos[10]="1.25 0.75 0.0";
	PEScale[10]="0.5 0.5 0.16666";
	
	PEName[11]="Out32";
	PEPos[11]="1.75 0.75 0.0";
	PEScale[11]="0.5 0.5 0.16666";
	
	PEName[12]="Out40";
	PEPos[12]="2.25 0.75 0.0";
	PEScale[12]="0.5 0.5 0.16666";
	
	PEName[13]="Out41";
	PEPos[13]="2.75 0.75 0.0";
	PEScale[13]="0.5 0.5 0.16666";
	
	PEName[14]="Out42";
	PEPos[14]="3.25 0.75 0.0";
	PEScale[14]="0.5 0.5 0.16666";
	
	numIE=9;
	
	IEName[0]="In0";
	IEPos[0]="3.75 -0.75 0.0";
	IEScale[0]="0.5 0.5 0.16666";
	
	IEName[1]="In1";
	IEPos[1]="3.25 -0.75 0.0";
	IEScale[1]="0.5 0.5 0.16666";
	
	IEName[2]="In2";
	IEPos[2]="2.75 -0.75 0.0";
	IEScale[2]="0.5 0.5 0.16666";
	
	IEName[3]="In3";
	IEPos[3]="2.25 -0.75 0.0";
	IEScale[3]="0.5 0.5 0.16666";
	
	IEName[4]="In4";
	IEPos[4]="1.75 -0.75 0.0";
	IEScale[4]="0.5 0.5 0.16666";
	
	IEName[5]="In5";
	IEPos[5]="1.25 -0.75 0.0";
	IEScale[5]="0.5 0.5 0.16666";
	
	IEName[6]="In6";
	IEPos[6]="0.75 -0.75 0.0";
	IEScale[6]="0.5 0.5 0.16666";

	IEName[7]="In7";
	IEPos[7]="0.25 -0.75 0.0";
	IEScale[7]="0.5 0.5 0.16666";
	
	IEName[8]="Clock";
	IEPos[8]="-3.75 -0.25 0.0";
	IEScale[8]="0.5 0.5 0.16666";
};
package moreRAM{
	function RAM8Bit8AddBitBrickData::DoLog(%data,%gate,%statestack,%client){
		%gate.currAddr=
			(%statestack.ins[11]*1)+
			(%statestack.ins[12]*2)+
			(%statestack.ins[13]*4)+
			(%statestack.ins[14]*8)+
			(%statestack.ins[15]*16)+
			(%statestack.ins[16]*32)+
			(%statestack.ins[17]*64)+
			(%statestack.ins[18]*128);
		if((%gate.IE[10].previousState==0)&&%statestack.ins[10]!=0){
			if(%statestack.ins[8]!=0){
				%gate.data[%gate.currAddr,0]=%statestack.ins[0];
				%gate.data[%gate.currAddr,1]=%statestack.ins[1];
				%gate.data[%gate.currAddr,2]=%statestack.ins[2];
				%gate.data[%gate.currAddr,3]=%statestack.ins[3];
				%gate.data[%gate.currAddr,4]=%statestack.ins[4];
				%gate.data[%gate.currAddr,5]=%statestack.ins[5];
				%gate.data[%gate.currAddr,6]=%statestack.ins[6];
				%gate.data[%gate.currAddr,7]=%statestack.ins[7];
			}
			if(%statestack.ins[9]!=0){
				setPEPowered(%gate.PE[0],%gate.data[%gate.currAddr,0],%client);
				setPEPowered(%gate.PE[1],%gate.data[%gate.currAddr,1],%client);
				setPEPowered(%gate.PE[2],%gate.data[%gate.currAddr,2],%client);
				setPEPowered(%gate.PE[3],%gate.data[%gate.currAddr,3],%client);
				setPEPowered(%gate.PE[4],%gate.data[%gate.currAddr,4],%client);
				setPEPowered(%gate.PE[5],%gate.data[%gate.currAddr,5],%client);
				setPEPowered(%gate.PE[6],%gate.data[%gate.currAddr,6],%client);
				setPEPowered(%gate.PE[7],%gate.data[%gate.currAddr,7],%client);
			}
		}
	}
	function ALU8Bit4OpBrickData::DoLog(%data,%gate,%statestack,%client){
		if((%gate.IE[20].previousState==0)&&%statestack.ins[20]!=0){
			%gate.input1=
				(%statestack.ins[0]*1)+
				(%statestack.ins[1]*2)+
				(%statestack.ins[2]*4)+
				(%statestack.ins[3]*8)+
				(%statestack.ins[4]*16)+
				(%statestack.ins[5]*32)+
				(%statestack.ins[6]*64)+
				(%statestack.ins[7]*128);
			%gate.input2=
				(%statestack.ins[8]*1)+
				(%statestack.ins[9]*2)+
				(%statestack.ins[10]*4)+
				(%statestack.ins[11]*8)+
				(%statestack.ins[12]*16)+
				(%statestack.ins[13]*32)+
				(%statestack.ins[14]*64)+
				(%statestack.ins[15]*128);
			%gate.opValue=
				(%statestack.ins[16]*1)+
				(%statestack.ins[17]*2)+
				(%statestack.ins[18]*4)+
				(%statestack.ins[19]*8);
			if(%statestack.ins[21]!=0)
				%gate.input1+=-1;
			if(%statestack.ins[22]!=0)
				%gate.input2*=-1;
			if(%opValue==-1)
				doNothing();
			else if(%gate.opValue==0)
				%gate.outputValue=%gate.input1&%gate.input2;
			else if(%gate.opValue==1)
				%gate.outputValue=%gate.input1|%gate.input2;
			else if(%gate.opValue==2)
				%gate.outputValue=%gate.input1^%gate.input2;
			else if(%gate.opValue==3)
				%gate.outputValue=~%gate.input1|%gate.input2;
			else if(%gate.opValue==4)
				%gate.outputValue=%gate.input1>>%gate.input2;
			else if(%gate.opValue==5)
				%gate.outputValue=%gate.input1<<%gate.input2;
			else if(%gate.opValue==6)
				%gate.outputValue=%gate.input1+%gate.input2;
			else if(%gate.opValue==7)
				%gate.outputValue=%gate.input1-%gate.input2;
			else if(%gate.opValue==8)
				%gate.outputValue=%gate.input1*%gate.input2;
			else if(%gate.opValue==9)
				if(%gate.input1>0&&%gate.input2>0)
					%gate.outputValue=%gate.input1/%gate.input2;
				else
					%gate.outputValue=0;
			else
				%gate.outputValue=0;
			if(%gate.outputValue<0)
				%gate.outputSign=1;
			else
				%gate.outputSign=0;
			%gate.outputValue=mFloor(mAbs(%gate.outputValue));
			for(%c=15;%c>=0;%c--){
				%placeValue=mPow(2,%c);
				if(%gate.outputValue>=%placeValue){
					%gate.outputValue-=%placeValue;
					setPEPowered(%gate.PE[%c],1,%client);
				}else{
					setPEPowered(%gate.PE[%c],0,%client);
				}
			}
			setPEPowered(%gate.PE[16],%gate.outputSign,%client);
		}
	}
	function Latch4BitBrickData::DoLog(%data,%gate,%statestack,%client){
		if((%gate.IE[5].previousState==0)&&%statestack.ins[5]!=0)
			for(%c=0;%c<4;%c++)
				setPEPowered(%gate.PE[%c],0,%client);
		else if((%gate.IE[4].previousState==0)&&%statestack.ins[4]!=0)
			for(%c=0;%c<4;%c++)
				setPEPowered(%gate.PE[%c],%statestack.ins[%c],%client);
	}
	function Latch8BitBrickData::DoLog(%data,%gate,%statestack,%client){
		if((%gate.IE[9].previousState==0)&&%statestack.ins[9]!=0)
			for(%c=0;%c<8;%c++)
				setPEPowered(%gate.PE[%c],0,%client);
		else if((%gate.IE[8].previousState==0)&&%statestack.ins[8]!=0)
			for(%c=0;%c<8;%c++)
				setPEPowered(%gate.PE[%c],%statestack.ins[%c],%client);
	}
	function Delay4BitBrickData::DoLog(%data,%gate,%statestack,%client){
		if(%gate.IE[4].previousState!=%statestack.ins[4]){
			%inputValue=0;
			for(%c=0;%c<4;%c++)
				if(%statestack.ins[%c])
					%inputValue+=mPow(2,%c);
			schedule(%inputValue*62.5/2,0,setPEPowered,%gate.PE[0],%statestack.ins[4],%client);
		}
	}
	function Any6BitBrickData::DoLog(%data,%gate,%statestack,%client){
		%gate.input=
			(%statestack.ins[0])+
			(%statestack.ins[1])+
			(%statestack.ins[2])+
			(%statestack.ins[3])+
			(%statestack.ins[4])+
			(%statestack.ins[5]);
		%gate.operator=
			(%statestack.ins[6]*1)+
			(%statestack.ins[7]*2)+
			(%statestack.ins[8]*4);
		%gate.negate=%statestack.ins[9];
		%truth=%gate.input==%gate.operator;
		if(%gate.negate)
			%truth=!%truth;
		setPEPowered(%gate.PE[0],%truth,%client);
	}
	function PulseFormerBrickData::DoLog(%data,%gate,%statestack,%client){
		if(%gate.IE[0].previousState==0&&%statestack.ins[0]!=0){
			setPEPowered(%gate.PE[0],1,%client);
			schedule(125,0,setPEPowered,%gate.PE[0],0,%client);
		}
	}
	function PulseFilterBrickData::DoLog(%data,%gate,%statestack,%client){
		if(%gate.IE[0].previousState==0&&%statestack.ins[0]!=0)
			schedule(125,0,rLogicEnableCurrent,%data,%gate,%statestack,%client);
		else if(%statestack.ins[0]==0)
			setPEPowered(%gate.PE[0],0,%client);
	}
	function rLogicEnableCurrent(%data,%gate,%statestack,%client){
		if(%statestack.ins[0]!=0)
			setPEPowered(%gate.PE[0],1,%client);
	}
	function Enable4BitBrickData::DoLog(%data,%gate,%statestack,%client){
		if((%statestack.ins[4]))
			for(%c=0;%c<4;%c++)
				setPEPowered(%gate.PE[%c],%statestack.ins[%c],%client);
		else
			for(%c=0;%c<4;%c++)
				setPEPowered(%gate.PE[%c],0,%client);
	}
	function Enable8BitBrickData::DoLog(%data,%gate,%statestack,%client){
		if((%statestack.ins[8]))
			for(%c=0;%c<8;%c++)
				setPEPowered(%gate.PE[%c],%statestack.ins[%c],%client);
		else
			for(%c=0;%c<8;%c++)
				setPEPowered(%gate.PE[%c],0,%client);
	}
	function SevSeg4BitBrickData::DoLog(%data,%gate,%statestack,%client){
		%gate.inputValue=0;
		for(%c=0;%c<4;%c++)
			if(%statestack.ins[%c]!=0)
				%gate.inputValue+=mPow(2,%c);
		%states[0]= "1111110";
		%states[1]= "0110000";
		%states[2]= "1101101";
		%states[3]= "1111001";
		%states[4]= "0110011";
		%states[5]= "1011011";
		%states[6]= "1011111";
		%states[7]= "1110000";
		%states[8]= "1111111";
		%states[9]= "1111011";
		%states[10]="1110111";
		%states[11]="0011111";
		%states[12]="1001110";
		%states[13]="0111101";
		%states[14]="1001111";
		%states[15]="1000111";
		%gate.outputBits=%states[%gate.inputValue];
		for(%c=0;%c<7;%c++){
			%bit=getSubStr(%gate.outputBits,%c,1);
			setPEPowered(%gate.PE[%c],%bit,%client);
		}
	}
	function JKLatchBrickData::DoLog(%data,%gate,%statestack,%client){
		if(%statestack.ins[2]!=0&&%gate.IE[2].previousState==0){
			%j=%statestack.ins[0];
			%k=%statestack.ins[1];
			%q=%gate.valQ;
			%qn=0;
			if(!(%j||%k))
				%qn=%q;
			else if(%k&&!%j)
				%qn=0;
			else if(%j&&!%k)
				%qn=1;
			else if(%j&&%k)
				%qn=!%q;
			SetPEPowered(%gate.PE[0],%qn,%client);
			SetPEPowered(%gate.PE[1],!%qn,%client);
			%gate.valQ=%qn;
		}
	}
	function LinearDLatchBrickData::DoLog(%data,%gate,%statestack,%client){
		if(%statestack.ins[0]!=0&&%gate.IE[0].previousState==0){
			SetPEPowered(%gate.PE[0],%statestack.ins[1],%client);
		}
	}
	function Letter6BitBrickData::DoLog(%data,%gate,%statestack,%client){
		if(%statestack.ins[8]!=0&&%gate.IE[8].previousState==0){
			%gate.inputValue=0;
			for(%c=0;%c<8;%c++)
				if(%statestack.ins[%c]!=0)
					%gate.inputValue+=mPow(2,%c);
			%numStates=-1;
			%states[%numStates++]="000000000000000";//space
			%states[%numStates++]="111111111111111";//block
			%states[%numStates++]="111101101101111";//0
			%states[%numStates++]="110010010010111";//1
			%states[%numStates++]="111001111100111";//2
			%states[%numStates++]="111001011001111";//3
			%states[%numStates++]="101101111001001";//4
			%states[%numStates++]="111100111001111";//5
			%states[%numStates++]="111100111101111";//6
			%states[%numStates++]="111001001001001";//7
			%states[%numStates++]="111101111101111";//8
			%states[%numStates++]="111101111001111";//9
			%states[%numStates++]="111101111101101";//a
			%states[%numStates++]="111101110101111";//b
			%states[%numStates++]="111100100100111";//c
			%states[%numStates++]="110101101101110";//d
			%states[%numStates++]="111100110100111";//e
			%states[%numStates++]="111100110100100";//f
			%states[%numStates++]="111100100101111";//g
			%states[%numStates++]="101101111101101";//h
			%states[%numStates++]="111010010010111";//i
			%states[%numStates++]="001001001101111";//j
			%states[%numStates++]="101101110101101";//k
			%states[%numStates++]="100100100100111";//l
			%states[%numStates++]="101111101101101";//m
			%states[%numStates++]="101111111101101";//n
			%states[%numStates++]="111101101101111";//o
			%states[%numStates++]="111101111100100";//p
			%states[%numStates++]="111101101110001";//q
			%states[%numStates++]="111101111110101";//r
			%states[%numStates++]="111100111001111";//s
			%states[%numStates++]="111010010010010";//t
			%states[%numStates++]="101101101101111";//u
			%states[%numStates++]="101101101111010";//v
			%states[%numStates++]="101101111111101";//w
			%states[%numStates++]="101101010101101";//x
			%states[%numStates++]="101101111010010";//y
			%states[%numStates++]="111001010100111";//z
			%states[%numStates++]="010010010000010";//!
			%states[%numStates++]="111001011000010";//?
			%states[%numStates++]="010111010010010";//up
			%states[%numStates++]="010010010111010";//down
			%states[%numStates++]="011010010110010";//rad
			%states[%numStates++]="000110001110000";//>
			%states[%numStates++]="000011100011000";//<
			%states[%numStates++]="010101000000000";//^
			%states[%numStates++]="101010101000000";//*
			%states[%numStates++]="010100100100010";//(
			%states[%numStates++]="010001001001010";//)
			%states[%numStates++]="110100100100110";//[
			%states[%numStates++]="011001001001011";//]
			%states[%numStates++]="010101100101010";//{
			%states[%numStates++]="010101001101010";//}
			%states[%numStates++]="000000111000000";//-
			%states[%numStates++]="000010111010000";//+
			%states[%numStates++]="000111000111000";//=
			%states[%numStates++]="000000000000111";//_
			%states[%numStates++]="001001010100100";///
			%states[%numStates++]="100100010001001";//backslash
			%states[%numStates++]="010010010010010";//|
			%states[%numStates++]="000000000011011";//.
			%states[%numStates++]="000000000001011";//,
			%states[%numStates++]="010010000000000";//'
			%states[%numStates++]="011011000001011";//;
			%states[%numStates++]="011011000011011";//:
			%gate.outputBits=%states[%gate.inputValue];
			for(%c=0;%c<15;%c++){
				%bit=getSubStr(%gate.outputBits,%c,1);
				setPEPowered(%gate.PE[%c],%bit,%client);
			}
		}
	}
};
activatePackage(moreRAM);
















