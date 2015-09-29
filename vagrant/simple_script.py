#!/usr/bin/env python3
import os

'''This is a simple script for showing a script running on both a host and a virtual machine via
Vagrant.
'''

def print_two_statements():
    print('Welcome to the [testing] jungle.')
    print('Current directory is ' + os.getcwd())

if __name__ == "__main__":
    print_two_statements()
