﻿using LuceneNetEFCoreSearchTools.Interfaces;

namespace LuceneNetEFCoreSearchTools
{
    public class LuceneIndexChange
    {

        public ILuceneIndexable Entity { get; set; }
        public LuceneIndexState State { get; set; }

        public LuceneIndexChange(ILuceneIndexable entity)
        {
            Entity = entity;
            State = LuceneIndexState.NotSet;
        }

        public LuceneIndexChange(ILuceneIndexable entity, LuceneIndexState state)
        {
            Entity = entity;
            State = state;
        }


    }
}
