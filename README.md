# cvColorSelectorGUI
An opensource project to find and test color range thresholds on color images for openCV.

Sometimes you need to test many color ranges to find propper range for your threshold ad filtering. 
It's realy hard to use openCV commands by just try and error. So having an easy GUI is good solution.

How to use:
1. Open your image file.
2. Select start color by LEFT-Click.
3. Select end color by RIGHT-CLICK.
4. Modify the range by numericUpDown or trackbar.
5. Save the range by Add Range button.
6. If you want to add another color range, you can use Union or Subtract. So find the range values by mouse Left and Right
   and add the range. To see the instant change, select the new range in range list and click EditRow button to change the
   values by live view. After modification, turn off EditRow.
   
Note:
- There is an sample video of working process in video folder.

Samples:
Selecting the hand:
![Screenshot](https://github.com/mshams/cvColorSelectorGUI/raw/master/cvColorSelectorGUI/images/results/hand-selection_hand.png)

Selecting the hand and blue ball:
![Screenshot](https://github.com/mshams/cvColorSelectorGUI/raw/master/cvColorSelectorGUI/images/results/hand-selection_hand-blue.png)

Selecting the blue and green:
![Screenshot](https://github.com/mshams/cvColorSelectorGUI/raw/master/cvColorSelectorGUI/images/results/rubik-selection_blue-green.png)

Selecting the blue and white:
![Screenshot](https://github.com/mshams/cvColorSelectorGUI/raw/master/cvColorSelectorGUI/images/results/rubik-selection_blue-wite.png)

Selecting the yellow and white
![Screenshot](https://github.com/mshams/cvColorSelectorGUI/raw/master/cvColorSelectorGUI/images/results/rubik-selection_yellow-wite.png)

Selecting the red and orange:
![Screenshot](https://github.com/mshams/cvColorSelectorGUI/raw/master/cvColorSelectorGUI/images/results/social-selection_red-orange.png)
