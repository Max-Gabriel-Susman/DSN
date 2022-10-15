// Copyright Epic Games, Inc. All Rights Reserved.

#include "DSNGameMode.h"
#include "DSNCharacter.h"
#include "UObject/ConstructorHelpers.h"

ADSNGameMode::ADSNGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
