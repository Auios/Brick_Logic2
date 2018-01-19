datablock fxDTSBrickData (SegmentBrick4x4Data : Powerbrick1x1Data)
{
	category = "Logic Bricks";
	subCategory = "Chips";
	uiName = "7 Seg Decoder";
	iconName = "base/client/ui/brickIcons/4x4f";
	brickFile = "Add-Ons/Brick_Logic2/bricks/Gate4x4f.blb";
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "7 Seg Decoder";
	TipInfo = "4bit value translates to their proper pins that\ncorrespond to a standard 7 segment display pins.\n(0 - F)";
	numIE = 4;
	IEName[0] = "Input3"; //1st on left
	IEPos[0] = "-0.75 -0.75 0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "Input2";
	IEPos[1] = "-0.25 -0.75 0";
	IEScale[1] = "0.5 0.5 0.16666";

	IEName[2] = "Input1";
	IEPos[2] = "0.25 -0.75 0"; 
	IEScale[2] = "0.5 0.5 0.16666";

	IEName[3] = "Input0"; //last from left
	IEPos[3] = "0.75 -0.75 0";
	IEScale[3] = "0.5 0.5 0.16666";

	numPE = 7;
	PEName[3] = "D"; //this should b accurate
	PEPos[3] = "0.25 0.25 0";
	PEScale[3] = "0.5 0.5 0.16666";
	PEStart[3] = 0;

	PEName[4] = "E"; 
	PEPos[4] = "0.75 -0.25 0";
	PEScale[4] = "0.5 0.5 0.16666";
	PEStart[4] = 0;
	
	PEName[5] = "F"; 
	PEPos[5] = "0.75 0.25 0";
	PEScale[5] = "0.5 0.5 0.16666";
	PEStart[5] = 0;
	
	PEName[0] = "A";
	PEPos[0] = "-0.25 0.75 0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;
	
	PEName[2] = "C"; 
	PEPos[2] = "-0.75 -0.25 0";
	PEScale[2] = "0.5 0.5 0.16666";
	PEStart[2] = 0;
	
	PEName[1] = "B"; 
	PEPos[1] = "-0.75 0.25 0";
	PEScale[1] = "0.5 0.5 0.16666";
	PEStart[1] = 0;

	PEName[6] = "G";
	PEPos[6] = "0.25 0.75 0";
	PEScale[6] = "0.5 0.5 0.16666";
	PEStart[6] = 0;
};

function SegmentBrick4x4Data::DoLog(%data,%gate,%statestack,%client)
{
	%A = %B = %C = %D = %E = %F = %G = 1;

	%gate.currentValue = (%statestack.ins[3] * 8) + (%statestack.ins[2] * 4) + (%statestack.ins[1] * 2) + (%statestack.ins[0] * 1);

	switch(%gate.currentValue)
	{
		case 0:
			%A = 1;
			%B = 1;
			%C = 1;
			%D = 1;
			%E = 1;
			%F = 1;
			%G = 0;

		case 1:
			%A = 0;
			%B = 1;
			%C = 1;
			%D = 0;
			%E = 0;
			%G = 0;

		case 2:
			%A = 1;
			%B = 1;
			%C = 0;
			%D = 1;
			%E = 1;
			%F = 0;
			%G = 1;

		case 3:
			%A = 1;
			%B = 1;
			%C = 1;
			%D = 1;
			%E = 0;
			%F = 0;
			%G = 1;

		case 4:
			%A = 0;
			%B = 1;
			%C = 1;
			%D = 0;
			%E = 0;
			%F = 1;
			%G = 1;

		case 5:
			%A = 1;
			%B = 0;
			%C = 1;
			%D = 1;
			%E = 0;
			%F = 1;
			%G = 1;

		case 6:
			%A = 1;
			%B = 0;
			%C = 1;
			%D = 1;
			%E = 1;
			%F = 1;
			%G = 1;

		case 7:
			%A = 1;
			%B = 1;
			%C = 1;
			%D = 0;
			%E = 0;
			%F = 0;
			%G = 0;

		case 8:
			%A = 1;
			%B = 1;
			%C = 1;
			%D = 1;
			%E = 1;
			%F = 1;
			%G = 1;

		case 9:
			%A = 1;
			%B = 1;
			%C = 1;
			%D = 0;
			%E = 0;
			%F = 1;
			%G = 1;

		case 10:
			%A = 1;
			%B = 1;
			%C = 1;
			%D = 0;
			%E = 1;
			%F = 1;
			%G = 1;

		case 11:
			%A = 0;
			%B = 0;
			%C = 1;
			%D = 1;
			%E = 1;
			%F = 1;
			%G = 1;

		case 12:
			%A = 1;
			%B = 0;
			%C = 0;
			%D = 1;
			%E = 1;
			%F = 1;
			%G = 0;

		case 13:
			%A = 0;
			%B = 1;
			%C = 1;
			%D = 1;
			%E = 1;
			%F = 0;
			%G = 1;

		case 14:
			%A = 1;
			%B = 0;
			%C = 0;
			%D = 1;
			%E = 1;
			%F = 1;
			%G = 1;

		case 15:
			%A = 1;
			%B = 0;
			%C = 0;
			%D = 0;
			%E = 1;
			%F = 1;
			%G = 1;
	}

	SetPEPowered(%gate.PE[0],%A,%client);
	SetPEPowered(%gate.PE[1],%B,%client);
	SetPEPowered(%gate.PE[2],%C,%client);
	SetPEPowered(%gate.PE[3],%D,%client);
	SetPEPowered(%gate.PE[4],%E,%client);
	SetPEPowered(%gate.PE[5],%F,%client);
	SetPEPowered(%gate.PE[6],%G,%client);
}