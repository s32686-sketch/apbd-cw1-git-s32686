# apbd-cw1-git-s32686

Adding a little change to README before merging feature_max

REASON FOR NON-FORWARD MERGE: branch 'main' changed while the work was done on the feature_max, so when merging, git can not just move the pointer, it needs and additional commit that would connect these 2 branches (effectively synchronizing them) 

ANSWERS TO QUESTIONS:
1.Fast forward is executed, when on the main branch there were no changes while working on the other branch. Non fast forward is done when there were changes on main and we need to synchronize 2 branches.
2.When doing the merge, in history we can see where exactly the branch started and merged with the main branch. On the other hand, rebase creates a 'seamless' line in history, which is sometimes cleaner, without additional merge commits 
3. My conflict was resolved by both keeping current change (by keeping the method which was in main, but not in 'feature_conflict' branch) and accepting incoming changes from 'feature_conflict' (by accepting it's messages to the user in CheckScore function instead of the messages in main)
