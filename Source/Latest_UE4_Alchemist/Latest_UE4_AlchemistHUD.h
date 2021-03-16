// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once 

#include "CoreMinimal.h"
#include "GameFramework/HUD.h"
#include "Latest_UE4_AlchemistHUD.generated.h"

UCLASS()
class ALatest_UE4_AlchemistHUD : public AHUD
{
	GENERATED_BODY()

public:
	ALatest_UE4_AlchemistHUD();

	/** Primary draw call for the HUD */
	virtual void DrawHUD() override;

private:
	/** Crosshair asset pointer */
	class UTexture2D* CrosshairTex;

};

