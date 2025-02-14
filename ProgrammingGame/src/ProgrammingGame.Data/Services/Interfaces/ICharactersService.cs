﻿using System;
using System.Collections.Generic;
using ProgrammingGame.Common.Enums;
using ProgrammingGame.Data.Entities;

namespace ProgrammingGame.Data.Services.Interfaces
{
    public interface ICharactersService
    {
        IEnumerable<Character> GetAllWithRelatedEntities();
        Character GetCharacterByIdWithIndicatorsAndItemsAndLogs(long characterId);
        Character GetCharacterByKey(Guid characterKey);
        void ActiveCharacter(long characterId);
        void CreateCharacter(string characterName, long userId);
        void SetCharacterState(Character character, CharacterStates newState);
        void AddExperienceToCharacter(Character character, long experienceToAdd);
        void LevelUpCharacter(Character character, long pointsSurplus);
        void ResetLastStateChangeTime(Character character);
        bool EnoughTimeHasPassedFromPreviousStatusAnalyze(Character character, TimeSpan delayBeetwenExecuting);
        void RenewIndicator(long characterId, IndicatorTypes indicatorType, int? amount = null);
    }
}