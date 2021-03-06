﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }
            return j;
        }
    }
}

/*
C++ Solution:
int removeElement(vector<int>& nums, int val) {
		if (nums.empty()) {
			return 0;
		}
		int j = 0;
		for (int i = 0; i < nums.size(); ++i) {
			if (nums[i] != val) {
				nums[j++] = nums[i];
			}
		}
		return j;
	}

 */