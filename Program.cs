//*****************************************************************************
//** 951. Flip Equivalent Binary Trees    leetcode                           **
//*****************************************************************************


/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     struct TreeNode *left;
 *     struct TreeNode *right;
 * };
 */

bool dfs(struct TreeNode* root1, struct TreeNode* root2) {
    if (root1 == root2 || (root1 == NULL && root2 == NULL)) {
        return true;
    }
    if (root1 == NULL || root2 == NULL || root1->val != root2->val) {
        return false;
    }
    return (dfs(root1->left, root2->left) && dfs(root1->right, root2->right)) ||
           (dfs(root1->left, root2->right) && dfs(root1->right, root2->left));
}

bool flipEquiv(struct TreeNode* root1, struct TreeNode* root2) {
    return dfs(root1, root2);
}