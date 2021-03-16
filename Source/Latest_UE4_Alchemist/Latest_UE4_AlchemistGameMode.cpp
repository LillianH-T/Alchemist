// Copyright Epic Games, Inc. All Rights Reserved.

#include "Latest_UE4_AlchemistGameMode.h"
#include "Latest_UE4_AlchemistHUD.h"
#include "Latest_UE4_AlchemistCharacter.h"
#include "UObject/ConstructorHelpers.h"

ALatest_UE4_AlchemistGameMode::ALatest_UE4_AlchemistGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPersonCPP/Blueprints/FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

	// use our custom HUD class
	HUDClass = ALatest_UE4_AlchemistHUD::StaticClass();
}
