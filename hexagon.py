#First row:
a=int(input("Enter side lenght : "))
space=" "*(a-1)
stars="*"*a
print(space+stars)
#First half:
space_copy=space
innerspace=" "*(a-2)
while True:
    if space=="":
        break
    space=space.replace(" ","",1)
    innerspace=innerspace+"  "
    print(space+"*"+innerspace+"*")
#Second half:
while True:
    if space == space_copy.replace(" ","",1):
        break
    space=space+" "
    innerspace=innerspace.replace(" ","",2)
    print(space+"*"+innerspace+"*")
#Last row:
print(space_copy+stars)
