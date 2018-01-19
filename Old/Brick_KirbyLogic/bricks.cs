datablock fxDTSBrickData (SegmentBrick4x4Data : Powerbrick1x1Data)
{
	category = "LogicBricks";
	subCategory = "Circuits";
	uiName = "Binary to Segment Gate";
	iconName = "base/client/ui/brickIcons/4x4f";
	brickFile = "Add-Ons/Brick_Logic/Gate4x4f.blb";
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "Binary2Segment";
	TipInfo = "Input is a binary digit from 0-9\nOutputs the pins to correctly display it on a standard 7 seg display";
	numIE = 4;
	IEName[0] = "Input8"; //1st on left
	IEPos[0] = "0.75 0.75 0";
	IEScale[0] = "0.5 0.5 0.16666";
	IEName[1] = "Input4";
	IEPos[1] = "0.25 0.75 0";
	IEScale[1] = "0.5 0.5 0.16666";
	IEName[2] = "Input2";
	IEPos[2] = "-0.25 0.75 0"; 
	IEScale[2] = "0.5 0.5 0.16666";
	IEName[3] = "Input1"; //last from left
	IEPos[3] = "-0.75 0.75 0";
	IEScale[3] = "0.5 0.5 0.16666";

	numPE = 7;
	PEName[3] = "D"; //this should b accurate
	PEPos[3] = "-0.25 -0.25 0";
	PEScale[3] = "0.5 0.5 0.16666";
	PEStart[3] = 0;

	PEName[4] = "E"; 
	PEPos[4] = "-0.75 0.25 0";
	PEScale[4] = "0.5 0.5 0.16666";
	PEStart[4] = 0;
	
	PEName[5] = "F"; 
	PEPos[5] = "-0.75 -0.25 0";
	PEScale[5] = "0.5 0.5 0.16666";
	PEStart[5] = 0;
	
	PEName[0] = "A";
	PEPos[0] = "0.25 -0.75 0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;
	
	PEName[2] = "C"; 
	PEPos[2] = "0.75 0.25 0";
	PEScale[2] = "0.5 0.5 0.16666";
	PEStart[2] = 0;
	
	PEName[1] = "B"; 
	PEPos[1] = "0.75 -0.25 0";
	PEScale[1] = "0.5 0.5 0.16666";
	PEStart[1] = 0;

	PEName[6] = "G";
	PEPos[6] = "-0.25 -0.75 0";
	PEScale[6] = "0.5 0.5 0.16666";
	PEStart[6] = 0;
};

package KirbyLogic{
	function SegmentBrick4x4Data::DoLog(%data,%gate,%statestack,%client)
	{
		%A = %B = %C = %D = %E = %F = %G = 1;

		if(!%statestack.ins[3] && !%statestack.ins[2] && !%statestack.ins[1] && !%statestack.ins[0]) //0
		{
			%G = 0;
			%A = %F = %G = %E = %D = 1;
		}

		if(!%statestack.ins[3] && !%statestack.ins[2] && !%statestack.ins[1] && %statestack.ins[0]) //1
		{
			%A = %D = %E = %F = %G = 0;
			%B = %C = 1;
		}

		if(!%statestack.ins[0])
		{
			if(!%statestack.ins[1])
			{
				if(!%statestack.ins[2])
				{
					if(!%statestack.ins[3]) //0000
					{
						%G = 0;
					}
					else //0001
					{
						%A = %F = %G = %E = %D = 0;
					}
				}
				else
				{
					if(!%statestack.ins[3]) //0010
					{
						%F = %C = 0;
					}
					else //0011
					{
						%F = %E = 0;
					}

				}
			}
			else
			{
				if(!%statestack.ins[2])
				{
					if(!%statestack.ins[3]) //0100
					{
						%A = %E = %D = 0;
					}
					else //0101
					{
						%B = %E = 0;
					}
				}
				else
				{
					if(!%statestack.ins[3]) //0110
					{
						%B = 0;
					}
					else //0111
					{
						%F = %G = %E = %D = 0;
					}

				}
			}
		}
		else
		{
			if(!%statestack.ins[1])
			{
				if(!%statestack.ins[2])
				{
					if(!%statestack.ins[3]) //1000
					{
						
					}
					else //1001
					{
						%E = 0;
					}
				}
				else
				{
					if(!%statestack.ins[3]) //1010 (A)
					{
						%D = 0;
					}
					else //1011 (B)
					{
						%A = %B = 0;
					}

				}
			}
			else
			{
				if(!%statestack.ins[2])
				{
					if(!%statestack.ins[3]) //1100 (C)
					{
						%B = %G = %C = 0;
					}
					else //1101 (D)
					{
						%A = %F = 0;
					}
				}
				else
				{
					if(!%statestack.ins[3]) //1110 (E)
					{
						%B = %C = 0;
					}
					else //1111 (F)
					{
						%B = %C = %D = 0;
					}

				}
			}
			//We don't need to make a case for 1000 because 8 is already represented by default, by the way we have it.

		}
		SetPEPowered(%gate.PE[0],%A,%client);
		SetPEPowered(%gate.PE[1],%B,%client);
		SetPEPowered(%gate.PE[2],%C,%client);
		SetPEPowered(%gate.PE[3],%D,%client);
		SetPEPowered(%gate.PE[4],%E,%client);
		SetPEPowered(%gate.PE[5],%F,%client);
		SetPEPowered(%gate.PE[6],%G,%client);
	}
};

activatePackage("KirbyLogic");